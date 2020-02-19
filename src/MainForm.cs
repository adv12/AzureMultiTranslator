// Copyright © 2020 Andrew Vardeman.  Published under the MIT license.
// See license.txt in the AzureMultiTranslator distribution or repository for the
// full text of the license.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace AzureMultiTranslator
{
    public partial class MainForm : Form
    {
        const string APPNAME = "AzureMultiTranslator";

        private Translator Translator { get; }

        private string SettingsDirPath { get; }

        private string SettingsPath { get; }

        private Settings Settings { get; }

        private List<TranslatedTextRow> BackingRows { get; } = new List<TranslatedTextRow>();

        public BindingList<TranslatedTextRow> Rows { get; }

        public MainForm()
        {
            InitializeComponent();

            Rows = new BindingList<TranslatedTextRow>(BackingRows);

            SettingsDirPath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), APPNAME);
            SettingsPath = Path.Combine(SettingsDirPath, "settings.json");
            if (File.Exists(SettingsPath))
            {
                try
                {
                    string json = File.ReadAllText(SettingsPath);
                    Settings = JsonConvert.DeserializeObject<Settings>(json);
                }
                catch (Exception)
                {
                }
            }
            if (Settings == null)
            {
                Settings = new Settings();
                Settings.WindowSize = this.Size;
                Settings.MainSplitContainerSplitterDistance = mainSplitContainer.SplitterDistance;
                Settings.TranslationsPaneSplitContainerSplitterDistance = translationsPaneSplitContainer.SplitterDistance;
                Settings.TranslationsTextBoxesSplitContainerSplitterDistance = translationsTextBoxesSplitContainer.SplitterDistance;
                Settings.Languages.Add("da");
                Settings.Languages.Add("de");
                Settings.Languages.Add("es");
                Settings.Languages.Add("fr");
                Settings.Languages.Add("hu");
                Settings.Languages.Add("nl");
                Settings.Languages.Add("ru");
            }
            int mainSplitContainerSplitterDistance =
                Settings.MainSplitContainerSplitterDistance;
            int translationsPaneSplitContainerSplitterDistance =
                Settings.TranslationsPaneSplitContainerSplitterDistance;
            int translationsTextBoxesSplitContainerSplitterDistance =
                Settings.TranslationsTextBoxesSplitContainerSplitterDistance;
            Size = Settings.WindowSize;
            mainSplitContainer.SplitterDistance =
                mainSplitContainerSplitterDistance;
            translationsPaneSplitContainer.SplitterDistance =
                translationsPaneSplitContainerSplitterDistance;
            translationsTextBoxesSplitContainer.SplitterDistance =
                translationsTextBoxesSplitContainerSplitterDistance;
            foreach (string language in Settings.Languages)
            {
                Rows.Add(new TranslatedTextRow(language));
            }
            Rows.ListChanged += Rows_ListChanged;
            Settings.PropertyChanged += Settings_PropertyChanged;
            Translator = new Translator(Settings);
            translatedTextRowBindingSource.DataSource = Rows;
            SyncBackTranslateUI();
            FireBackTranslate();
        }

        private async void Settings_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == nameof(Settings.BackTranslate))
            {
                SyncBackTranslateUI();
                FireBackTranslate();
            }
            if (e.PropertyName == nameof(Settings.SubscriptionKey))
            {
                UpdateTranslateButton();
            }
            settingsTimer.Stop();
            settingsTimer.Start();
        }

        private void Rows_ListChanged(object sender, ListChangedEventArgs e)
        {
            Settings.Languages.Clear();
            foreach (string language in Rows.Select(r => r.Language))
            {
                Settings.Languages.Add(language);
            }
        }

        private void translationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewColumn column = translationGrid.Columns[e.ColumnIndex];
            if (column == CopyTranslatedColumn || column == copyBackTranslatedColumn)
            {
                string text = (string)translationGrid.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value;
                if (string.IsNullOrEmpty(text))
                {
                    Clipboard.Clear();
                }
                else
                {
                    Clipboard.SetText(text);
                }
            }

            translatedTextBox.Text = "" + Rows[e.RowIndex].TranslatedText;
            backTranslatedTextBox.Text = "" + Rows[e.RowIndex].BackTranslatedText;

            if (column == deleteColumn)
            {
                DialogResult result = MessageBox.Show(
                   $"Remove language \"{Rows[e.RowIndex].Language}\"?", "Remove Language?",
                   MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    Rows.RemoveAt(e.RowIndex);
                }
            }
        }

        private void addLanguageButton_Click(object sender, EventArgs e)
        {
            Rows.Add(new TranslatedTextRow(addLanguageTextBox.Text));
            addLanguageTextBox.Clear();
        }

        private async void translateButton_Click(object sender, EventArgs e)
        {
            Enabled = false;
            string[] languages = new string[Rows.Count];
            for (int i = 0; i < languages.Length; i++)
            {
                languages[i] = Rows[i].Language;
            }

            try
            {
                List<string> translations = await Translator.Translate(Settings.SourceLanguage,
                    languages, englishTextBox.Text, htmlCheckBox.Checked);
                for (int i = 0; i < translations.Count; i++)
                {
                    Rows[i].TranslatedText = translations[i];
                }
                await BackTranslate();
            }
            catch (AzureException ex)
            {
                ShowAzureException(ex);
            }
            catch (UnrecognizedResponseException ex)
            {
                ShowUnrecognizedResponseException(ex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, $"Unknown exception: {ex.Message}");
            }

            if (translationGrid.SelectedRows.Count > 0)
            {
                translationGrid_CellContentClick(translationGrid,
                   new DataGridViewCellEventArgs(0, translationGrid.SelectedRows[0].Index));
            }

            Enabled = true;
        }

        private async void FireBackTranslate()
        {
            await BackTranslate();
        }

        private async Task BackTranslate()
        {
            bool savedEnabledState = Enabled;
            Enabled = false;
            foreach (TranslatedTextRow row in Rows)
            {
                if (Settings.BackTranslate)
                {
                    if (string.IsNullOrEmpty(row.TranslatedText))
                    {
                        row.BackTranslatedText = string.Empty;
                    }
                    else if (row.TranslatedText.Length <= 5000)
                    {
                        try
                        {
                            List<string> backTranslations =
                               await Translator.Translate(row.Language, new[] { Settings.SourceLanguage },
                                  row.TranslatedText, htmlCheckBox.Checked);
                            row.BackTranslatedText = backTranslations[0];
                        }
                        catch (AzureException ex)
                        {
                            ShowAzureException(ex);
                        }
                        catch (UnrecognizedResponseException ex)
                        {
                            ShowUnrecognizedResponseException(ex);
                        }
                    }
                    else
                    {
                        row.BackTranslatedText = "Too long to back-translate";
                    }
                }
                else
                {
                    row.BackTranslatedText = "";
                }
            }
            Enabled = savedEnabledState;
        }

        private void ShowAzureException(AzureException ex)
        {
            MessageBox.Show(this, $"Azure error {ex.Code}: {ex.Message}");
        }

        private void ShowUnrecognizedResponseException(UnrecognizedResponseException ex)
        {
            MessageBox.Show(this, ex.Message);
        }

        private void SyncBackTranslateUI()
        {
            translationGrid.Columns[3].Visible = translationGrid.Columns[4].Visible =
                Settings.BackTranslate;
            translationsTextBoxesSplitContainer.Panel2Collapsed = !Settings.BackTranslate;
        }

        private void UpdateTranslateButton()
        {
            int length = englishTextBox.Text.Length;
            translateButton.Enabled = length > 0 && length <= 5000 && !string.IsNullOrWhiteSpace(Settings.SubscriptionKey);
        }

        private void englishTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateTranslateButton();
            lengthTextBox.Text = englishTextBox.Text.Length.ToString();
            if (translateButton.Enabled)
            {
                lengthTextBox.ForeColor = SystemColors.ControlText;
            }
            else
            {
                lengthTextBox.ForeColor = Color.Red;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            settingsBindingSource.DataSource = Settings;
        }

        private void settingsTimer_Tick(object sender, EventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            Directory.CreateDirectory(SettingsDirPath);
            string subscriptionKey = Settings.SubscriptionKey;
            if (!Settings.SaveSubscriptionKey)
            {
                // temporarily blank this out to save if the user doesn't want it persisted
                Settings.SubscriptionKey = "";
            }
            string json = JsonConvert.SerializeObject(Settings);
            // restore the subscription key if it was blanked out
            Settings.SubscriptionKey = subscriptionKey;
            // kill the timer we just started by changing the settings
            settingsTimer.Stop();
            File.WriteAllText(SettingsPath, json);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void mainSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            Settings.MainSplitContainerSplitterDistance = mainSplitContainer.SplitterDistance;
        }

        private void translationsPaneSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            Settings.TranslationsPaneSplitContainerSplitterDistance = translationsPaneSplitContainer.SplitterDistance;
        }

        private void translationsTextBoxesSplitContainer_SplitterMoved(object sender, SplitterEventArgs e)
        {
            Settings.TranslationsTextBoxesSplitContainerSplitterDistance = translationsTextBoxesSplitContainer.SplitterDistance;
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (Settings != null)
            {
                Settings.WindowSize = Size;
            }
        }

        private void addLanguageTextBox_Enter(object sender, EventArgs e)
        {
            AcceptButton = addLanguageButton;
        }

        private void addLanguageTextBox_Leave(object sender, EventArgs e)
        {
            AcceptButton = null;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            BackingRows.Sort((r1, r2) => r1.Language.CompareTo(r2.Language));
            Rows.ResetBindings();
        }

        private void upButton_Click(object sender, EventArgs e)
        {
            List<int> selectedIndices = GetSelectedIndices();
            if (selectedIndices.Count > 0)
            {
                int insertIndex = selectedIndices[0];
                if (insertIndex > 0)
                {
                    insertIndex--;
                }

                List<TranslatedTextRow> rows = GetRowsAtIndices(selectedIndices);
                BackingRows.RemoveAll(r => rows.Contains(r));
                ReinsertAndSelect(insertIndex, rows);
            }
        }

        private void downButton_Click(object sender, EventArgs e)
        {
            List<int> selectedIndices = GetSelectedIndices();
            if (selectedIndices.Count > 0)
            {
                TranslatedTextRow rowToInsertAfter = null;
                int newIndex = selectedIndices.Last();
                if (newIndex < BackingRows.Count - 1)
                {
                    rowToInsertAfter = Rows[newIndex + 1];
                }
                List<TranslatedTextRow> rows = GetRowsAtIndices(selectedIndices);
                BackingRows.RemoveAll(r => rows.Contains(r));
                int insertIndex = BackingRows.Count;
                if (rowToInsertAfter != null)
                {
                    insertIndex = BackingRows.IndexOf(rowToInsertAfter) + 1;
                }
                ReinsertAndSelect(insertIndex, rows);
            }
        }

        private List<int> GetSelectedIndices()
        {
            List<int> selectedIndices = new List<int>();
            var selectedRows = translationGrid.SelectedRows;
            if (selectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in selectedRows)
                {
                    selectedIndices.Add(row.Index);
                }
            }
            selectedIndices.Sort();

            return selectedIndices;
        }

        private List<TranslatedTextRow> GetRowsAtIndices(List<int> indices)
        {
            List<TranslatedTextRow> rows = new List<TranslatedTextRow>();
            foreach (int index in indices)
            {
                rows.Add(Rows[index]);
            }

            return rows;
        }

        private void ReinsertAndSelect(int insertIndex, List<TranslatedTextRow> rows)
        {
            BackingRows.InsertRange(insertIndex, rows);
            Rows.ResetBindings();
            translationGrid.ClearSelection();
            for (int i = insertIndex; i < insertIndex + rows.Count; i++)
            {
                translationGrid.Rows[i].Selected = true;
            }
        }
    }
}
