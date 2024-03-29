﻿namespace AzureMultiTranslator
{
   partial class MainForm
   {
      /// <summary>
      /// Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      /// Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      /// Required method for Designer support - do not modify
      /// the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
            this.components = new System.ComponentModel.Container();
            this.sourceTextBox = new System.Windows.Forms.TextBox();
            this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
            this.panel2 = new System.Windows.Forms.Panel();
            this.languageTextBox = new System.Windows.Forms.TextBox();
            this.settingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.htmlCheckBox = new System.Windows.Forms.CheckBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.translationsPaneSplitContainer = new System.Windows.Forms.SplitContainer();
            this.translationGrid = new System.Windows.Forms.DataGridView();
            this.Translate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.translatedTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copyTranslatedColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.backTranslatedTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.copyBackTranslatedColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this.translatedTextRowBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.translationsTextBoxesSplitContainer = new System.Windows.Forms.SplitContainer();
            this.translatedTextBox = new System.Windows.Forms.TextBox();
            this.translatedLabel = new System.Windows.Forms.Label();
            this.backTranslatedTextBox = new System.Windows.Forms.TextBox();
            this.backTranslatedLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.upButton = new System.Windows.Forms.Button();
            this.downButton = new System.Windows.Forms.Button();
            this.sortButton = new System.Windows.Forms.Button();
            this.backTranslateCheckBox = new System.Windows.Forms.CheckBox();
            this.addLanguageButton = new System.Windows.Forms.Button();
            this.addLanguageTextBox = new System.Windows.Forms.TextBox();
            this.translateButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.maxCharsUpDown = new System.Windows.Forms.NumericUpDown();
            this.maxCharsLabel = new System.Windows.Forms.Label();
            this.rememberKeyCheckBox = new System.Windows.Forms.CheckBox();
            this.subscriptionKeyTextBox = new System.Windows.Forms.TextBox();
            this.keyLabel = new System.Windows.Forms.Label();
            this.endpointTextBox = new System.Windows.Forms.TextBox();
            this.endpointLabel = new System.Windows.Forms.Label();
            this.settingsTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
            this.mainSplitContainer.Panel1.SuspendLayout();
            this.mainSplitContainer.Panel2.SuspendLayout();
            this.mainSplitContainer.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translationsPaneSplitContainer)).BeginInit();
            this.translationsPaneSplitContainer.Panel1.SuspendLayout();
            this.translationsPaneSplitContainer.Panel2.SuspendLayout();
            this.translationsPaneSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translatedTextRowBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.translationsTextBoxesSplitContainer)).BeginInit();
            this.translationsTextBoxesSplitContainer.Panel1.SuspendLayout();
            this.translationsTextBoxesSplitContainer.Panel2.SuspendLayout();
            this.translationsTextBoxesSplitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCharsUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceTextBox
            // 
            this.sourceTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sourceTextBox.Location = new System.Drawing.Point(0, 37);
            this.sourceTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sourceTextBox.Multiline = true;
            this.sourceTextBox.Name = "sourceTextBox";
            this.sourceTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.sourceTextBox.Size = new System.Drawing.Size(379, 573);
            this.sourceTextBox.TabIndex = 0;
            this.sourceTextBox.TextChanged += new System.EventHandler(this.englishTextBox_TextChanged);
            // 
            // mainSplitContainer
            // 
            this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainSplitContainer.Location = new System.Drawing.Point(0, 37);
            this.mainSplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mainSplitContainer.Name = "mainSplitContainer";
            // 
            // mainSplitContainer.Panel1
            // 
            this.mainSplitContainer.Panel1.Controls.Add(this.sourceTextBox);
            this.mainSplitContainer.Panel1.Controls.Add(this.panel2);
            // 
            // mainSplitContainer.Panel2
            // 
            this.mainSplitContainer.Panel2.Controls.Add(this.translationsPaneSplitContainer);
            this.mainSplitContainer.Panel2.Controls.Add(this.panel1);
            this.mainSplitContainer.Size = new System.Drawing.Size(1148, 610);
            this.mainSplitContainer.SplitterDistance = 379;
            this.mainSplitContainer.SplitterWidth = 5;
            this.mainSplitContainer.TabIndex = 1;
            this.mainSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.mainSplitContainer_SplitterMoved);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.languageTextBox);
            this.panel2.Controls.Add(this.lengthTextBox);
            this.panel2.Controls.Add(this.lengthLabel);
            this.panel2.Controls.Add(this.htmlCheckBox);
            this.panel2.Controls.Add(this.languageLabel);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 37);
            this.panel2.TabIndex = 2;
            // 
            // languageTextBox
            // 
            this.languageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "SourceLanguage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.languageTextBox.Location = new System.Drawing.Point(77, 8);
            this.languageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.Size = new System.Drawing.Size(60, 23);
            this.languageTextBox.TabIndex = 6;
            // 
            // settingsBindingSource
            // 
            this.settingsBindingSource.DataSource = typeof(AzureMultiTranslator.Settings);
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lengthTextBox.Location = new System.Drawing.Point(315, 8);
            this.lengthTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(62, 23);
            this.lengthTextBox.TabIndex = 5;
            this.lengthTextBox.Text = "0";
            // 
            // lengthLabel
            // 
            this.lengthLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lengthLabel.Location = new System.Drawing.Point(259, 10);
            this.lengthLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(47, 15);
            this.lengthLabel.TabIndex = 4;
            this.lengthLabel.Text = "Length:";
            // 
            // htmlCheckBox
            // 
            this.htmlCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.htmlCheckBox.AutoSize = true;
            this.htmlCheckBox.Checked = true;
            this.htmlCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.htmlCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.settingsBindingSource, "Html", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.htmlCheckBox.Location = new System.Drawing.Point(194, 9);
            this.htmlCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.htmlCheckBox.Name = "htmlCheckBox";
            this.htmlCheckBox.Size = new System.Drawing.Size(58, 19);
            this.htmlCheckBox.TabIndex = 2;
            this.htmlCheckBox.Text = "HTML";
            this.htmlCheckBox.UseVisualStyleBackColor = true;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(9, 10);
            this.languageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(59, 15);
            this.languageLabel.TabIndex = 1;
            this.languageLabel.Text = "Language";
            // 
            // translationsPaneSplitContainer
            // 
            this.translationsPaneSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.translationsPaneSplitContainer.Location = new System.Drawing.Point(0, 37);
            this.translationsPaneSplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.translationsPaneSplitContainer.Name = "translationsPaneSplitContainer";
            this.translationsPaneSplitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // translationsPaneSplitContainer.Panel1
            // 
            this.translationsPaneSplitContainer.Panel1.Controls.Add(this.translationGrid);
            // 
            // translationsPaneSplitContainer.Panel2
            // 
            this.translationsPaneSplitContainer.Panel2.Controls.Add(this.translationsTextBoxesSplitContainer);
            this.translationsPaneSplitContainer.Size = new System.Drawing.Size(764, 573);
            this.translationsPaneSplitContainer.SplitterDistance = 194;
            this.translationsPaneSplitContainer.SplitterWidth = 5;
            this.translationsPaneSplitContainer.TabIndex = 3;
            this.translationsPaneSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.translationsPaneSplitContainer_SplitterMoved);
            // 
            // translationGrid
            // 
            this.translationGrid.AutoGenerateColumns = false;
            this.translationGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.translationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.translationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Translate,
            this.languageDataGridViewTextBoxColumn,
            this.translatedTextDataGridViewTextBoxColumn,
            this.copyTranslatedColumn,
            this.backTranslatedTextDataGridViewTextBoxColumn,
            this.copyBackTranslatedColumn,
            this.deleteColumn});
            this.translationGrid.DataSource = this.translatedTextRowBindingSource;
            this.translationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.translationGrid.Location = new System.Drawing.Point(0, 0);
            this.translationGrid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.translationGrid.Name = "translationGrid";
            this.translationGrid.RowHeadersVisible = false;
            this.translationGrid.RowHeadersWidth = 82;
            this.translationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.translationGrid.Size = new System.Drawing.Size(764, 194);
            this.translationGrid.TabIndex = 0;
            this.translationGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.translationGrid_CellContentClick);
            // 
            // Translate
            // 
            this.Translate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.Translate.DataPropertyName = "Translate";
            this.Translate.HeaderText = "";
            this.Translate.Name = "Translate";
            this.Translate.Width = 5;
            // 
            // languageDataGridViewTextBoxColumn
            // 
            this.languageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
            this.languageDataGridViewTextBoxColumn.HeaderText = "";
            this.languageDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
            this.languageDataGridViewTextBoxColumn.ReadOnly = true;
            this.languageDataGridViewTextBoxColumn.Width = 10;
            // 
            // translatedTextDataGridViewTextBoxColumn
            // 
            this.translatedTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.translatedTextDataGridViewTextBoxColumn.DataPropertyName = "TranslatedText";
            this.translatedTextDataGridViewTextBoxColumn.HeaderText = "Translated";
            this.translatedTextDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.translatedTextDataGridViewTextBoxColumn.Name = "translatedTextDataGridViewTextBoxColumn";
            // 
            // copyTranslatedColumn
            // 
            this.copyTranslatedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.copyTranslatedColumn.DataPropertyName = "Copy";
            this.copyTranslatedColumn.HeaderText = "";
            this.copyTranslatedColumn.MinimumWidth = 10;
            this.copyTranslatedColumn.Name = "copyTranslatedColumn";
            this.copyTranslatedColumn.ReadOnly = true;
            this.copyTranslatedColumn.Width = 10;
            // 
            // backTranslatedTextDataGridViewTextBoxColumn
            // 
            this.backTranslatedTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.backTranslatedTextDataGridViewTextBoxColumn.DataPropertyName = "BackTranslatedText";
            this.backTranslatedTextDataGridViewTextBoxColumn.HeaderText = "Back-Translated";
            this.backTranslatedTextDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.backTranslatedTextDataGridViewTextBoxColumn.Name = "backTranslatedTextDataGridViewTextBoxColumn";
            // 
            // copyBackTranslatedColumn
            // 
            this.copyBackTranslatedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.copyBackTranslatedColumn.DataPropertyName = "Copy";
            this.copyBackTranslatedColumn.HeaderText = "";
            this.copyBackTranslatedColumn.MinimumWidth = 10;
            this.copyBackTranslatedColumn.Name = "copyBackTranslatedColumn";
            this.copyBackTranslatedColumn.ReadOnly = true;
            this.copyBackTranslatedColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.copyBackTranslatedColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.copyBackTranslatedColumn.Width = 19;
            // 
            // deleteColumn
            // 
            this.deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.deleteColumn.DataPropertyName = "Remove";
            this.deleteColumn.HeaderText = "";
            this.deleteColumn.MinimumWidth = 10;
            this.deleteColumn.Name = "deleteColumn";
            this.deleteColumn.ReadOnly = true;
            this.deleteColumn.Width = 10;
            // 
            // translatedTextRowBindingSource
            // 
            this.translatedTextRowBindingSource.DataSource = typeof(AzureMultiTranslator.TranslatedTextRow);
            // 
            // translationsTextBoxesSplitContainer
            // 
            this.translationsTextBoxesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.translationsTextBoxesSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.translationsTextBoxesSplitContainer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.translationsTextBoxesSplitContainer.Name = "translationsTextBoxesSplitContainer";
            // 
            // translationsTextBoxesSplitContainer.Panel1
            // 
            this.translationsTextBoxesSplitContainer.Panel1.Controls.Add(this.translatedTextBox);
            this.translationsTextBoxesSplitContainer.Panel1.Controls.Add(this.translatedLabel);
            // 
            // translationsTextBoxesSplitContainer.Panel2
            // 
            this.translationsTextBoxesSplitContainer.Panel2.Controls.Add(this.backTranslatedTextBox);
            this.translationsTextBoxesSplitContainer.Panel2.Controls.Add(this.backTranslatedLabel);
            this.translationsTextBoxesSplitContainer.Size = new System.Drawing.Size(764, 374);
            this.translationsTextBoxesSplitContainer.SplitterDistance = 380;
            this.translationsTextBoxesSplitContainer.SplitterWidth = 5;
            this.translationsTextBoxesSplitContainer.TabIndex = 2;
            this.translationsTextBoxesSplitContainer.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.translationsTextBoxesSplitContainer_SplitterMoved);
            // 
            // translatedTextBox
            // 
            this.translatedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.translatedTextBox.Location = new System.Drawing.Point(0, 15);
            this.translatedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.translatedTextBox.Multiline = true;
            this.translatedTextBox.Name = "translatedTextBox";
            this.translatedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.translatedTextBox.Size = new System.Drawing.Size(380, 359);
            this.translatedTextBox.TabIndex = 0;
            // 
            // translatedLabel
            // 
            this.translatedLabel.AutoSize = true;
            this.translatedLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.translatedLabel.Location = new System.Drawing.Point(0, 0);
            this.translatedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.translatedLabel.Name = "translatedLabel";
            this.translatedLabel.Size = new System.Drawing.Size(60, 15);
            this.translatedLabel.TabIndex = 1;
            this.translatedLabel.Text = "Translated";
            // 
            // backTranslatedTextBox
            // 
            this.backTranslatedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backTranslatedTextBox.Location = new System.Drawing.Point(0, 15);
            this.backTranslatedTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.backTranslatedTextBox.Multiline = true;
            this.backTranslatedTextBox.Name = "backTranslatedTextBox";
            this.backTranslatedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.backTranslatedTextBox.Size = new System.Drawing.Size(379, 359);
            this.backTranslatedTextBox.TabIndex = 3;
            // 
            // backTranslatedLabel
            // 
            this.backTranslatedLabel.AutoSize = true;
            this.backTranslatedLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.backTranslatedLabel.Location = new System.Drawing.Point(0, 0);
            this.backTranslatedLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.backTranslatedLabel.Name = "backTranslatedLabel";
            this.backTranslatedLabel.Size = new System.Drawing.Size(90, 15);
            this.backTranslatedLabel.TabIndex = 2;
            this.backTranslatedLabel.Text = "Back-Translated";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.upButton);
            this.panel1.Controls.Add(this.downButton);
            this.panel1.Controls.Add(this.sortButton);
            this.panel1.Controls.Add(this.backTranslateCheckBox);
            this.panel1.Controls.Add(this.addLanguageButton);
            this.panel1.Controls.Add(this.addLanguageTextBox);
            this.panel1.Controls.Add(this.translateButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(764, 37);
            this.panel1.TabIndex = 1;
            // 
            // upButton
            // 
            this.upButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.upButton.AutoSize = true;
            this.upButton.Location = new System.Drawing.Point(465, 5);
            this.upButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.upButton.Name = "upButton";
            this.upButton.Size = new System.Drawing.Size(29, 29);
            this.upButton.TabIndex = 7;
            this.upButton.Text = "⯅";
            this.upButton.UseVisualStyleBackColor = true;
            this.upButton.Click += new System.EventHandler(this.upButton_Click);
            // 
            // downButton
            // 
            this.downButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.downButton.AutoSize = true;
            this.downButton.Location = new System.Drawing.Point(502, 5);
            this.downButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.downButton.Name = "downButton";
            this.downButton.Size = new System.Drawing.Size(29, 29);
            this.downButton.TabIndex = 6;
            this.downButton.Text = "⯆";
            this.downButton.UseVisualStyleBackColor = true;
            this.downButton.Click += new System.EventHandler(this.downButton_Click);
            // 
            // sortButton
            // 
            this.sortButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.sortButton.AutoSize = true;
            this.sortButton.Location = new System.Drawing.Point(536, 5);
            this.sortButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(44, 29);
            this.sortButton.TabIndex = 5;
            this.sortButton.Text = "Sort";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.sortButton_Click);
            // 
            // backTranslateCheckBox
            // 
            this.backTranslateCheckBox.AutoSize = true;
            this.backTranslateCheckBox.Checked = true;
            this.backTranslateCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.backTranslateCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.settingsBindingSource, "BackTranslate", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.backTranslateCheckBox.Location = new System.Drawing.Point(96, 9);
            this.backTranslateCheckBox.Margin = new System.Windows.Forms.Padding(2);
            this.backTranslateCheckBox.Name = "backTranslateCheckBox";
            this.backTranslateCheckBox.Size = new System.Drawing.Size(102, 19);
            this.backTranslateCheckBox.TabIndex = 4;
            this.backTranslateCheckBox.Text = "Back-Translate";
            this.backTranslateCheckBox.UseVisualStyleBackColor = true;
            // 
            // addLanguageButton
            // 
            this.addLanguageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addLanguageButton.AutoSize = true;
            this.addLanguageButton.Location = new System.Drawing.Point(655, 5);
            this.addLanguageButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addLanguageButton.Name = "addLanguageButton";
            this.addLanguageButton.Size = new System.Drawing.Size(100, 29);
            this.addLanguageButton.TabIndex = 2;
            this.addLanguageButton.Text = "Add Language";
            this.addLanguageButton.UseVisualStyleBackColor = true;
            this.addLanguageButton.Click += new System.EventHandler(this.addLanguageButton_Click);
            // 
            // addLanguageTextBox
            // 
            this.addLanguageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addLanguageTextBox.Location = new System.Drawing.Point(588, 8);
            this.addLanguageTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.addLanguageTextBox.Name = "addLanguageTextBox";
            this.addLanguageTextBox.Size = new System.Drawing.Size(59, 23);
            this.addLanguageTextBox.TabIndex = 1;
            this.addLanguageTextBox.Enter += new System.EventHandler(this.addLanguageTextBox_Enter);
            this.addLanguageTextBox.Leave += new System.EventHandler(this.addLanguageTextBox_Leave);
            // 
            // translateButton
            // 
            this.translateButton.Location = new System.Drawing.Point(4, 5);
            this.translateButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.translateButton.Name = "translateButton";
            this.translateButton.Size = new System.Drawing.Size(88, 27);
            this.translateButton.TabIndex = 3;
            this.translateButton.Text = "Translate!";
            this.translateButton.UseVisualStyleBackColor = true;
            this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.maxCharsUpDown);
            this.panel3.Controls.Add(this.maxCharsLabel);
            this.panel3.Controls.Add(this.rememberKeyCheckBox);
            this.panel3.Controls.Add(this.subscriptionKeyTextBox);
            this.panel3.Controls.Add(this.keyLabel);
            this.panel3.Controls.Add(this.endpointTextBox);
            this.panel3.Controls.Add(this.endpointLabel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1148, 37);
            this.panel3.TabIndex = 2;
            // 
            // maxCharsUpDown
            // 
            this.maxCharsUpDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxCharsUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.settingsBindingSource, "MaxChars", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.maxCharsUpDown.Increment = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.maxCharsUpDown.Location = new System.Drawing.Point(1060, 9);
            this.maxCharsUpDown.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.maxCharsUpDown.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.maxCharsUpDown.Name = "maxCharsUpDown";
            this.maxCharsUpDown.Size = new System.Drawing.Size(78, 23);
            this.maxCharsUpDown.TabIndex = 7;
            this.maxCharsUpDown.Value = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            // 
            // maxCharsLabel
            // 
            this.maxCharsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maxCharsLabel.AutoSize = true;
            this.maxCharsLabel.Location = new System.Drawing.Point(987, 12);
            this.maxCharsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maxCharsLabel.Name = "maxCharsLabel";
            this.maxCharsLabel.Size = new System.Drawing.Size(63, 15);
            this.maxCharsLabel.TabIndex = 6;
            this.maxCharsLabel.Text = "Max Chars";
            // 
            // rememberKeyCheckBox
            // 
            this.rememberKeyCheckBox.AutoSize = true;
            this.rememberKeyCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("Checked", this.settingsBindingSource, "SaveSubscriptionKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.rememberKeyCheckBox.Location = new System.Drawing.Point(861, 9);
            this.rememberKeyCheckBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.rememberKeyCheckBox.Name = "rememberKeyCheckBox";
            this.rememberKeyCheckBox.Size = new System.Drawing.Size(84, 19);
            this.rememberKeyCheckBox.TabIndex = 4;
            this.rememberKeyCheckBox.Text = "Remember";
            this.rememberKeyCheckBox.UseVisualStyleBackColor = true;
            // 
            // subscriptionKeyTextBox
            // 
            this.subscriptionKeyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "SubscriptionKey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.subscriptionKeyTextBox.Location = new System.Drawing.Point(522, 8);
            this.subscriptionKeyTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.subscriptionKeyTextBox.Name = "subscriptionKeyTextBox";
            this.subscriptionKeyTextBox.Size = new System.Drawing.Size(334, 23);
            this.subscriptionKeyTextBox.TabIndex = 3;
            // 
            // keyLabel
            // 
            this.keyLabel.AutoSize = true;
            this.keyLabel.Location = new System.Drawing.Point(413, 10);
            this.keyLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.keyLabel.Name = "keyLabel";
            this.keyLabel.Size = new System.Drawing.Size(95, 15);
            this.keyLabel.TabIndex = 2;
            this.keyLabel.Text = "Subscription Key";
            // 
            // endpointTextBox
            // 
            this.endpointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.settingsBindingSource, "Endpoint", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.endpointTextBox.Location = new System.Drawing.Point(72, 8);
            this.endpointTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.endpointTextBox.Name = "endpointTextBox";
            this.endpointTextBox.Size = new System.Drawing.Size(334, 23);
            this.endpointTextBox.TabIndex = 1;
            // 
            // endpointLabel
            // 
            this.endpointLabel.AutoSize = true;
            this.endpointLabel.Location = new System.Drawing.Point(9, 10);
            this.endpointLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.endpointLabel.Name = "endpointLabel";
            this.endpointLabel.Size = new System.Drawing.Size(55, 15);
            this.endpointLabel.TabIndex = 0;
            this.endpointLabel.Text = "Endpoint";
            // 
            // settingsTimer
            // 
            this.settingsTimer.Interval = 250;
            this.settingsTimer.Tick += new System.EventHandler(this.settingsTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 647);
            this.Controls.Add(this.mainSplitContainer);
            this.Controls.Add(this.panel3);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "AzureMultiTranslator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Move += new System.EventHandler(this.MainForm_Move);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.mainSplitContainer.Panel1.ResumeLayout(false);
            this.mainSplitContainer.Panel1.PerformLayout();
            this.mainSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
            this.mainSplitContainer.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.settingsBindingSource)).EndInit();
            this.translationsPaneSplitContainer.Panel1.ResumeLayout(false);
            this.translationsPaneSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.translationsPaneSplitContainer)).EndInit();
            this.translationsPaneSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.translationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.translatedTextRowBindingSource)).EndInit();
            this.translationsTextBoxesSplitContainer.Panel1.ResumeLayout(false);
            this.translationsTextBoxesSplitContainer.Panel1.PerformLayout();
            this.translationsTextBoxesSplitContainer.Panel2.ResumeLayout(false);
            this.translationsTextBoxesSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.translationsTextBoxesSplitContainer)).EndInit();
            this.translationsTextBoxesSplitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.maxCharsUpDown)).EndInit();
            this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.TextBox sourceTextBox;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.DataGridView translationGrid;
        private System.Windows.Forms.BindingSource translatedTextRowBindingSource;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button addLanguageButton;
        private System.Windows.Forms.TextBox addLanguageTextBox;
        private System.Windows.Forms.Button translateButton;
        private System.Windows.Forms.CheckBox htmlCheckBox;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.SplitContainer translationsTextBoxesSplitContainer;
        private System.Windows.Forms.TextBox translatedTextBox;
        private System.Windows.Forms.Label translatedLabel;
        private System.Windows.Forms.TextBox backTranslatedTextBox;
        private System.Windows.Forms.Label backTranslatedLabel;
        private System.Windows.Forms.SplitContainer translationsPaneSplitContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox subscriptionKeyTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox endpointTextBox;
        private System.Windows.Forms.Label endpointLabel;
        private System.Windows.Forms.CheckBox rememberKeyCheckBox;
        private System.Windows.Forms.BindingSource settingsBindingSource;
        private System.Windows.Forms.Timer settingsTimer;
        private System.Windows.Forms.TextBox languageTextBox;
        private System.Windows.Forms.CheckBox backTranslateCheckBox;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.Button upButton;
        private System.Windows.Forms.Button downButton;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Translate;
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translatedTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn copyTranslatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backTranslatedTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn copyBackTranslatedColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.Label maxCharsLabel;
        private System.Windows.Forms.NumericUpDown maxCharsUpDown;
    }
}

