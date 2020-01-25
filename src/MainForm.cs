using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace AzureMultiTranslator
{
   public partial class MainForm : Form
   {

      public Translator Translator { get; } = new Translator();

      public BindingList<TranslatedTextRow> Rows { get; } = new BindingList<TranslatedTextRow>();

      public MainForm()
      {
         InitializeComponent();
         Rows.Add(new TranslatedTextRow("da"));
         Rows.Add(new TranslatedTextRow("de"));
         Rows.Add(new TranslatedTextRow("es"));
         Rows.Add(new TranslatedTextRow("fr"));
         Rows.Add(new TranslatedTextRow("hu"));
         Rows.Add(new TranslatedTextRow("nl"));
         Rows.Add(new TranslatedTextRow("ru"));
         translatedTextRowBindingSource.DataSource = Rows;
      }

        private void translationGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           if (e.ColumnIndex == 2 || e.ColumnIndex == 4)
           {
              string text = (string) translationGrid.Rows[e.RowIndex].Cells[e.ColumnIndex - 1].Value;
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

              if (e.ColumnIndex == 5)
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
      }

      private async void translateButton_Click(object sender, EventArgs e)
      {
         Enabled = false;
         string[] languages = new string[Rows.Count];
         for (int i = 0; i < languages.Length; i++)
         {
            languages[i] = Rows[i].Language;
         }

         List<string> translations = await Translator.Translate("en", languages, englishTextBox.Text, htmlCheckBox.Checked);
         for (int i = 0; i < translations.Count; i++)
         { 
            Rows[i].TranslatedText = translations[i];
            if (translations[i].Length <= 5000)
            {
               List<string> backTranslations =
                  await Translator.Translate(languages[i], new[] {"en"},
                     translations[i], htmlCheckBox.Checked);
               Rows[i].BackTranslatedText = backTranslations[0];
            }
            else
            {
               Rows[i].BackTranslatedText = "Too long to back-translate";
            }
         }

         if (translationGrid.SelectedRows.Count > 0)
         {
            translationGrid_CellContentClick(translationGrid,
               new DataGridViewCellEventArgs(0, translationGrid.SelectedRows[0].Index));
         }

         Enabled = true;
      }

      private void englishTextBox_TextChanged(object sender, EventArgs e)
      {
         translateButton.Enabled = englishTextBox.Text.Length <= 5000;
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
         translatorBindingSource.DataSource = Translator;
      }
   }
}
