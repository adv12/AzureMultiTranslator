namespace AzureMultiTranslator
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
         this.englishTextBox = new System.Windows.Forms.TextBox();
         this.mainSplitContainer = new System.Windows.Forms.SplitContainer();
         this.panel2 = new System.Windows.Forms.Panel();
         this.lengthTextBox = new System.Windows.Forms.TextBox();
         this.lengthLabel = new System.Windows.Forms.Label();
         this.translateButton = new System.Windows.Forms.Button();
         this.htmlCheckBox = new System.Windows.Forms.CheckBox();
         this.englishTextLabel = new System.Windows.Forms.Label();
         this.translationsPaneSplitContainer = new System.Windows.Forms.SplitContainer();
         this.translationGrid = new System.Windows.Forms.DataGridView();
         this.languageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.translatedTextDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
         this.CopyTranslatedColumn = new System.Windows.Forms.DataGridViewButtonColumn();
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
         this.addLanguageButton = new System.Windows.Forms.Button();
         this.addLanguageTextBox = new System.Windows.Forms.TextBox();
         this.panel3 = new System.Windows.Forms.Panel();
         this.rememberKeyCheckBox = new System.Windows.Forms.CheckBox();
         this.subscriptionKeyTextBox = new System.Windows.Forms.TextBox();
         this.translatorBindingSource = new System.Windows.Forms.BindingSource(this.components);
         this.keyLabel = new System.Windows.Forms.Label();
         this.endpointTextBox = new System.Windows.Forms.TextBox();
         this.endpointLabel = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).BeginInit();
         this.mainSplitContainer.Panel1.SuspendLayout();
         this.mainSplitContainer.Panel2.SuspendLayout();
         this.mainSplitContainer.SuspendLayout();
         this.panel2.SuspendLayout();
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
         ((System.ComponentModel.ISupportInitialize)(this.translatorBindingSource)).BeginInit();
         this.SuspendLayout();
         // 
         // englishTextBox
         // 
         this.englishTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.englishTextBox.Location = new System.Drawing.Point(0, 32);
         this.englishTextBox.Multiline = true;
         this.englishTextBox.Name = "englishTextBox";
         this.englishTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.englishTextBox.Size = new System.Drawing.Size(325, 497);
         this.englishTextBox.TabIndex = 0;
         this.englishTextBox.TextChanged += new System.EventHandler(this.englishTextBox_TextChanged);
         // 
         // mainSplitContainer
         // 
         this.mainSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.mainSplitContainer.Location = new System.Drawing.Point(0, 32);
         this.mainSplitContainer.Name = "mainSplitContainer";
         // 
         // mainSplitContainer.Panel1
         // 
         this.mainSplitContainer.Panel1.Controls.Add(this.englishTextBox);
         this.mainSplitContainer.Panel1.Controls.Add(this.panel2);
         // 
         // mainSplitContainer.Panel2
         // 
         this.mainSplitContainer.Panel2.Controls.Add(this.translationsPaneSplitContainer);
         this.mainSplitContainer.Panel2.Controls.Add(this.panel1);
         this.mainSplitContainer.Size = new System.Drawing.Size(984, 529);
         this.mainSplitContainer.SplitterDistance = 325;
         this.mainSplitContainer.TabIndex = 1;
         // 
         // panel2
         // 
         this.panel2.Controls.Add(this.lengthTextBox);
         this.panel2.Controls.Add(this.lengthLabel);
         this.panel2.Controls.Add(this.translateButton);
         this.panel2.Controls.Add(this.htmlCheckBox);
         this.panel2.Controls.Add(this.englishTextLabel);
         this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel2.Location = new System.Drawing.Point(0, 0);
         this.panel2.Name = "panel2";
         this.panel2.Size = new System.Drawing.Size(325, 32);
         this.panel2.TabIndex = 2;
         // 
         // lengthTextBox
         // 
         this.lengthTextBox.Location = new System.Drawing.Point(170, 6);
         this.lengthTextBox.Name = "lengthTextBox";
         this.lengthTextBox.Size = new System.Drawing.Size(54, 20);
         this.lengthTextBox.TabIndex = 5;
         this.lengthTextBox.Text = "0";
         // 
         // lengthLabel
         // 
         this.lengthLabel.AutoSize = true;
         this.lengthLabel.ForeColor = System.Drawing.SystemColors.ControlText;
         this.lengthLabel.Location = new System.Drawing.Point(121, 9);
         this.lengthLabel.Name = "lengthLabel";
         this.lengthLabel.Size = new System.Drawing.Size(43, 13);
         this.lengthLabel.TabIndex = 4;
         this.lengthLabel.Text = "Length:";
         // 
         // translateButton
         // 
         this.translateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.translateButton.Location = new System.Drawing.Point(247, 4);
         this.translateButton.Name = "translateButton";
         this.translateButton.Size = new System.Drawing.Size(75, 23);
         this.translateButton.TabIndex = 3;
         this.translateButton.Text = "Translate!";
         this.translateButton.UseVisualStyleBackColor = true;
         this.translateButton.Click += new System.EventHandler(this.translateButton_Click);
         // 
         // htmlCheckBox
         // 
         this.htmlCheckBox.AutoSize = true;
         this.htmlCheckBox.Checked = true;
         this.htmlCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
         this.htmlCheckBox.Location = new System.Drawing.Point(59, 8);
         this.htmlCheckBox.Name = "htmlCheckBox";
         this.htmlCheckBox.Size = new System.Drawing.Size(56, 17);
         this.htmlCheckBox.TabIndex = 2;
         this.htmlCheckBox.Text = "HTML";
         this.htmlCheckBox.UseVisualStyleBackColor = true;
         // 
         // englishTextLabel
         // 
         this.englishTextLabel.AutoSize = true;
         this.englishTextLabel.Location = new System.Drawing.Point(12, 9);
         this.englishTextLabel.Name = "englishTextLabel";
         this.englishTextLabel.Size = new System.Drawing.Size(41, 13);
         this.englishTextLabel.TabIndex = 1;
         this.englishTextLabel.Text = "English";
         // 
         // translationsPaneSplitContainer
         // 
         this.translationsPaneSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.translationsPaneSplitContainer.Location = new System.Drawing.Point(0, 32);
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
         this.translationsPaneSplitContainer.Size = new System.Drawing.Size(655, 497);
         this.translationsPaneSplitContainer.SplitterDistance = 171;
         this.translationsPaneSplitContainer.TabIndex = 3;
         // 
         // translationGrid
         // 
         this.translationGrid.AutoGenerateColumns = false;
         this.translationGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
         this.translationGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
         this.translationGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.languageDataGridViewTextBoxColumn,
            this.translatedTextDataGridViewTextBoxColumn,
            this.CopyTranslatedColumn,
            this.backTranslatedTextDataGridViewTextBoxColumn,
            this.copyBackTranslatedColumn,
            this.deleteColumn});
         this.translationGrid.DataSource = this.translatedTextRowBindingSource;
         this.translationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
         this.translationGrid.Location = new System.Drawing.Point(0, 0);
         this.translationGrid.Name = "translationGrid";
         this.translationGrid.RowHeadersVisible = false;
         this.translationGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
         this.translationGrid.Size = new System.Drawing.Size(655, 171);
         this.translationGrid.TabIndex = 0;
         this.translationGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.translationGrid_CellContentClick);
         // 
         // languageDataGridViewTextBoxColumn
         // 
         this.languageDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
         this.languageDataGridViewTextBoxColumn.DataPropertyName = "Language";
         this.languageDataGridViewTextBoxColumn.HeaderText = "";
         this.languageDataGridViewTextBoxColumn.Name = "languageDataGridViewTextBoxColumn";
         this.languageDataGridViewTextBoxColumn.Width = 5;
         // 
         // translatedTextDataGridViewTextBoxColumn
         // 
         this.translatedTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.translatedTextDataGridViewTextBoxColumn.DataPropertyName = "TranslatedText";
         this.translatedTextDataGridViewTextBoxColumn.HeaderText = "Translated";
         this.translatedTextDataGridViewTextBoxColumn.Name = "translatedTextDataGridViewTextBoxColumn";
         // 
         // CopyTranslatedColumn
         // 
         this.CopyTranslatedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
         this.CopyTranslatedColumn.DataPropertyName = "Copy";
         this.CopyTranslatedColumn.HeaderText = "";
         this.CopyTranslatedColumn.Name = "CopyTranslatedColumn";
         this.CopyTranslatedColumn.ReadOnly = true;
         this.CopyTranslatedColumn.Width = 5;
         // 
         // backTranslatedTextDataGridViewTextBoxColumn
         // 
         this.backTranslatedTextDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
         this.backTranslatedTextDataGridViewTextBoxColumn.DataPropertyName = "BackTranslatedText";
         this.backTranslatedTextDataGridViewTextBoxColumn.HeaderText = "Back-Translated";
         this.backTranslatedTextDataGridViewTextBoxColumn.Name = "backTranslatedTextDataGridViewTextBoxColumn";
         // 
         // copyBackTranslatedColumn
         // 
         this.copyBackTranslatedColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
         this.copyBackTranslatedColumn.DataPropertyName = "Copy";
         this.copyBackTranslatedColumn.HeaderText = "";
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
         this.deleteColumn.Name = "deleteColumn";
         this.deleteColumn.ReadOnly = true;
         this.deleteColumn.Width = 5;
         // 
         // translatedTextRowBindingSource
         // 
         this.translatedTextRowBindingSource.DataSource = typeof(AzureMultiTranslator.TranslatedTextRow);
         // 
         // translationsTextBoxesSplitContainer
         // 
         this.translationsTextBoxesSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
         this.translationsTextBoxesSplitContainer.Location = new System.Drawing.Point(0, 0);
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
         this.translationsTextBoxesSplitContainer.Size = new System.Drawing.Size(655, 322);
         this.translationsTextBoxesSplitContainer.SplitterDistance = 316;
         this.translationsTextBoxesSplitContainer.TabIndex = 2;
         // 
         // translatedTextBox
         // 
         this.translatedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.translatedTextBox.Location = new System.Drawing.Point(0, 13);
         this.translatedTextBox.Multiline = true;
         this.translatedTextBox.Name = "translatedTextBox";
         this.translatedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.translatedTextBox.Size = new System.Drawing.Size(316, 309);
         this.translatedTextBox.TabIndex = 0;
         // 
         // translatedLabel
         // 
         this.translatedLabel.AutoSize = true;
         this.translatedLabel.Dock = System.Windows.Forms.DockStyle.Top;
         this.translatedLabel.Location = new System.Drawing.Point(0, 0);
         this.translatedLabel.Name = "translatedLabel";
         this.translatedLabel.Size = new System.Drawing.Size(57, 13);
         this.translatedLabel.TabIndex = 1;
         this.translatedLabel.Text = "Translated";
         // 
         // backTranslatedTextBox
         // 
         this.backTranslatedTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
         this.backTranslatedTextBox.Location = new System.Drawing.Point(0, 13);
         this.backTranslatedTextBox.Multiline = true;
         this.backTranslatedTextBox.Name = "backTranslatedTextBox";
         this.backTranslatedTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
         this.backTranslatedTextBox.Size = new System.Drawing.Size(335, 309);
         this.backTranslatedTextBox.TabIndex = 3;
         // 
         // backTranslatedLabel
         // 
         this.backTranslatedLabel.AutoSize = true;
         this.backTranslatedLabel.Dock = System.Windows.Forms.DockStyle.Top;
         this.backTranslatedLabel.Location = new System.Drawing.Point(0, 0);
         this.backTranslatedLabel.Name = "backTranslatedLabel";
         this.backTranslatedLabel.Size = new System.Drawing.Size(85, 13);
         this.backTranslatedLabel.TabIndex = 2;
         this.backTranslatedLabel.Text = "Back-Translated";
         // 
         // panel1
         // 
         this.panel1.Controls.Add(this.addLanguageButton);
         this.panel1.Controls.Add(this.addLanguageTextBox);
         this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel1.Location = new System.Drawing.Point(0, 0);
         this.panel1.Name = "panel1";
         this.panel1.Size = new System.Drawing.Size(655, 32);
         this.panel1.TabIndex = 1;
         // 
         // addLanguageButton
         // 
         this.addLanguageButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.addLanguageButton.AutoSize = true;
         this.addLanguageButton.Location = new System.Drawing.Point(556, 4);
         this.addLanguageButton.Name = "addLanguageButton";
         this.addLanguageButton.Size = new System.Drawing.Size(87, 23);
         this.addLanguageButton.TabIndex = 2;
         this.addLanguageButton.Text = "Add Language";
         this.addLanguageButton.UseVisualStyleBackColor = true;
         this.addLanguageButton.Click += new System.EventHandler(this.addLanguageButton_Click);
         // 
         // addLanguageTextBox
         // 
         this.addLanguageTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
         this.addLanguageTextBox.Location = new System.Drawing.Point(499, 6);
         this.addLanguageTextBox.Name = "addLanguageTextBox";
         this.addLanguageTextBox.Size = new System.Drawing.Size(51, 20);
         this.addLanguageTextBox.TabIndex = 1;
         // 
         // panel3
         // 
         this.panel3.Controls.Add(this.rememberKeyCheckBox);
         this.panel3.Controls.Add(this.subscriptionKeyTextBox);
         this.panel3.Controls.Add(this.keyLabel);
         this.panel3.Controls.Add(this.endpointTextBox);
         this.panel3.Controls.Add(this.endpointLabel);
         this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
         this.panel3.Location = new System.Drawing.Point(0, 0);
         this.panel3.Name = "panel3";
         this.panel3.Size = new System.Drawing.Size(984, 32);
         this.panel3.TabIndex = 2;
         // 
         // rememberKeyCheckBox
         // 
         this.rememberKeyCheckBox.AutoSize = true;
         this.rememberKeyCheckBox.Location = new System.Drawing.Point(740, 8);
         this.rememberKeyCheckBox.Name = "rememberKeyCheckBox";
         this.rememberKeyCheckBox.Size = new System.Drawing.Size(77, 17);
         this.rememberKeyCheckBox.TabIndex = 4;
         this.rememberKeyCheckBox.Text = "Remember";
         this.rememberKeyCheckBox.UseVisualStyleBackColor = true;
         // 
         // subscriptionKeyTextBox
         // 
         this.subscriptionKeyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.translatorBindingSource, "SubscriptionKey", true));
         this.subscriptionKeyTextBox.Location = new System.Drawing.Point(447, 6);
         this.subscriptionKeyTextBox.Name = "subscriptionKeyTextBox";
         this.subscriptionKeyTextBox.Size = new System.Drawing.Size(287, 20);
         this.subscriptionKeyTextBox.TabIndex = 3;
         // 
         // translatorBindingSource
         // 
         this.translatorBindingSource.DataSource = typeof(AzureMultiTranslator.Translator);
         // 
         // keyLabel
         // 
         this.keyLabel.AutoSize = true;
         this.keyLabel.Location = new System.Drawing.Point(360, 9);
         this.keyLabel.Name = "keyLabel";
         this.keyLabel.Size = new System.Drawing.Size(86, 13);
         this.keyLabel.TabIndex = 2;
         this.keyLabel.Text = "Subscription Key";
         // 
         // endpointTextBox
         // 
         this.endpointTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.translatorBindingSource, "Endpoint", true));
         this.endpointTextBox.Location = new System.Drawing.Point(67, 6);
         this.endpointTextBox.Name = "endpointTextBox";
         this.endpointTextBox.Size = new System.Drawing.Size(287, 20);
         this.endpointTextBox.TabIndex = 1;
         // 
         // endpointLabel
         // 
         this.endpointLabel.AutoSize = true;
         this.endpointLabel.Location = new System.Drawing.Point(12, 9);
         this.endpointLabel.Name = "endpointLabel";
         this.endpointLabel.Size = new System.Drawing.Size(49, 13);
         this.endpointLabel.TabIndex = 0;
         this.endpointLabel.Text = "Endpoint";
         // 
         // MainForm
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(984, 561);
         this.Controls.Add(this.mainSplitContainer);
         this.Controls.Add(this.panel3);
         this.Name = "MainForm";
         this.Text = "AzureMultiTranslator";
         this.Load += new System.EventHandler(this.MainForm_Load);
         this.mainSplitContainer.Panel1.ResumeLayout(false);
         this.mainSplitContainer.Panel1.PerformLayout();
         this.mainSplitContainer.Panel2.ResumeLayout(false);
         ((System.ComponentModel.ISupportInitialize)(this.mainSplitContainer)).EndInit();
         this.mainSplitContainer.ResumeLayout(false);
         this.panel2.ResumeLayout(false);
         this.panel2.PerformLayout();
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
         ((System.ComponentModel.ISupportInitialize)(this.translatorBindingSource)).EndInit();
         this.ResumeLayout(false);

      }

        #endregion

        private System.Windows.Forms.TextBox englishTextBox;
        private System.Windows.Forms.SplitContainer mainSplitContainer;
        private System.Windows.Forms.Label englishTextLabel;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn languageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn translatedTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn CopyTranslatedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn backTranslatedTextDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn copyBackTranslatedColumn;
        private System.Windows.Forms.DataGridViewButtonColumn deleteColumn;
        private System.Windows.Forms.SplitContainer translationsPaneSplitContainer;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox subscriptionKeyTextBox;
        private System.Windows.Forms.Label keyLabel;
        private System.Windows.Forms.TextBox endpointTextBox;
        private System.Windows.Forms.Label endpointLabel;
        private System.Windows.Forms.CheckBox rememberKeyCheckBox;
        private System.Windows.Forms.BindingSource translatorBindingSource;
    }
}

