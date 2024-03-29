﻿namespace Note_Taking_Application
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
            bAdd = new Button();
            tbNoteText = new TextBox();
            bRemove = new Button();
            bSave = new Button();
            dataGridView = new DataGridView();
            noteModelBindingSource = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)noteModelBindingSource).BeginInit();
            SuspendLayout();
            // 
            // bAdd
            // 
            bAdd.AutoSize = true;
            bAdd.BackgroundImageLayout = ImageLayout.Stretch;
            bAdd.ForeColor = SystemColors.ActiveCaptionText;
            bAdd.Location = new Point(621, 10);
            bAdd.Name = "bAdd";
            bAdd.Size = new Size(74, 68);
            bAdd.TabIndex = 1;
            bAdd.Text = "Add";
            bAdd.UseVisualStyleBackColor = true;
            bAdd.Click += bAdd_Click;
            // 
            // tbNoteText
            // 
            tbNoteText.AcceptsReturn = true;
            tbNoteText.AcceptsTab = true;
            tbNoteText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            tbNoteText.Enabled = false;
            tbNoteText.Location = new Point(293, 0);
            tbNoteText.Multiline = true;
            tbNoteText.Name = "tbNoteText";
            tbNoteText.Size = new Size(310, 462);
            tbNoteText.TabIndex = 2;
            // 
            // bRemove
            // 
            bRemove.Location = new Point(620, 101);
            bRemove.Name = "bRemove";
            bRemove.Size = new Size(75, 23);
            bRemove.TabIndex = 6;
            bRemove.Text = "Remove";
            bRemove.UseVisualStyleBackColor = true;
            bRemove.Click += bRemove_Click;
            // 
            // bSave
            // 
            bSave.Enabled = false;
            bSave.Location = new Point(621, 129);
            bSave.Margin = new Padding(3, 2, 3, 2);
            bSave.Name = "bSave";
            bSave.RightToLeft = RightToLeft.No;
            bSave.Size = new Size(74, 22);
            bSave.TabIndex = 8;
            bSave.Text = "Save";
            bSave.UseVisualStyleBackColor = true;
            bSave.Click += bSave_Click;
            // 
            // dataGridView
            // 
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(2, 0);
            dataGridView.Name = "dataGridView";
            dataGridView.RowTemplate.Height = 25;
            dataGridView.Size = new Size(285, 449);
            dataGridView.TabIndex = 9;
            dataGridView.CellBeginEdit += dataGridView_CellBeginEdit;
            dataGridView.CellEndEdit += dataGridView_CellEndEdit;
            dataGridView.SelectionChanged += dataGridView_SelectionChanged;
            // 
            // noteModelBindingSource
            // 
            noteModelBindingSource.DataSource = typeof(DataManagement.NoteModel);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(719, 461);
            Controls.Add(dataGridView);
            Controls.Add(bSave);
            Controls.Add(bRemove);
            Controls.Add(tbNoteText);
            Controls.Add(bAdd);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)noteModelBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button bAdd;
        private TextBox tbNoteText;
        private Button bRemove;
        private Button bSave;
        private DataGridView dataGridView;
        private BindingSource noteModelBindingSource;
    }
}