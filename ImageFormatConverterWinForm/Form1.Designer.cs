namespace ImageFormatConverterWinForm
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            imporFolderButton = new Button();
            importFileButton = new Button();
            exportButton = new Button();
            removeSelectedButton = new Button();
            formatComboBox = new ComboBox();
            createDirectoryCheckBox = new CheckBox();
            label1 = new Label();
            fileListBox = new ListBox();
            form1BindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).BeginInit();
            SuspendLayout();
            // 
            // imporFolderButton
            // 
            imporFolderButton.Location = new Point(409, 59);
            imporFolderButton.Name = "imporFolderButton";
            imporFolderButton.Size = new Size(175, 38);
            imporFolderButton.TabIndex = 1;
            imporFolderButton.Text = "Import Folder";
            imporFolderButton.UseVisualStyleBackColor = true;
            imporFolderButton.Click += OnImportFolderClick;
            // 
            // importFileButton
            // 
            importFileButton.Location = new Point(409, 120);
            importFileButton.Name = "importFileButton";
            importFileButton.Size = new Size(175, 38);
            importFileButton.TabIndex = 2;
            importFileButton.Text = "Import File";
            importFileButton.UseVisualStyleBackColor = true;
            importFileButton.Click += OnImportFileClick;
            // 
            // exportButton
            // 
            exportButton.Location = new Point(409, 176);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(175, 38);
            exportButton.TabIndex = 3;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = true;
            exportButton.Click += OnExportClick;
            // 
            // removeSelectedButton
            // 
            removeSelectedButton.Location = new Point(409, 237);
            removeSelectedButton.Name = "removeSelectedButton";
            removeSelectedButton.Size = new Size(175, 38);
            removeSelectedButton.TabIndex = 4;
            removeSelectedButton.Text = "Remove Selected";
            removeSelectedButton.UseVisualStyleBackColor = true;
            removeSelectedButton.Click += OnRemoveClick;
            // 
            // formatComboBox
            // 
            formatComboBox.AllowDrop = true;
            formatComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            formatComboBox.FormattingEnabled = true;
            formatComboBox.Location = new Point(421, 319);
            formatComboBox.Name = "formatComboBox";
            formatComboBox.Size = new Size(151, 28);
            formatComboBox.TabIndex = 5;
            // 
            // createDirectoryCheckBox
            // 
            createDirectoryCheckBox.AutoSize = true;
            createDirectoryCheckBox.Checked = true;
            createDirectoryCheckBox.CheckState = CheckState.Checked;
            createDirectoryCheckBox.Location = new Point(421, 359);
            createDirectoryCheckBox.Name = "createDirectoryCheckBox";
            createDirectoryCheckBox.Size = new Size(141, 24);
            createDirectoryCheckBox.TabIndex = 6;
            createDirectoryCheckBox.Text = "Create Directory";
            createDirectoryCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 296);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 7;
            label1.Text = "Convert Target";
            // 
            // fileListBox
            // 
            fileListBox.AllowDrop = true;
            fileListBox.FormattingEnabled = true;
            fileListBox.HorizontalScrollbar = true;
            fileListBox.Location = new Point(34, 59);
            fileListBox.Name = "fileListBox";
            fileListBox.ScrollAlwaysVisible = true;
            fileListBox.SelectionMode = SelectionMode.MultiExtended;
            fileListBox.Size = new Size(352, 324);
            fileListBox.TabIndex = 0;
            fileListBox.SelectedValueChanged += OnSelectChange;
            fileListBox.DragDrop += OnDropFile;
            fileListBox.DragEnter += OnDragFileEnter;
            // 
            // form1BindingSource
            // 
            form1BindingSource.DataSource = typeof(Form1);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(622, 433);
            Controls.Add(label1);
            Controls.Add(createDirectoryCheckBox);
            Controls.Add(formatComboBox);
            Controls.Add(removeSelectedButton);
            Controls.Add(exportButton);
            Controls.Add(importFileButton);
            Controls.Add(imporFolderButton);
            Controls.Add(fileListBox);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)form1BindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button imporFolderButton;
        private Button importFileButton;
        private Button exportButton;
        private Button removeSelectedButton;
        private ComboBox formatComboBox;
        private CheckBox createDirectoryCheckBox;
        private Label label1;
        private ListBox fileListBox;
        private BindingSource form1BindingSource;
    }
}
