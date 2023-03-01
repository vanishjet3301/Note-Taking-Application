namespace Note_Taking_Application
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
            this.LBCount = new System.Windows.Forms.ListBox();
            this.bAdd = new System.Windows.Forms.Button();
            this.tbNoteText = new System.Windows.Forms.TextBox();
            this.bRename = new System.Windows.Forms.Button();
            this.RenameTB = new System.Windows.Forms.TextBox();
            this.LBNames = new System.Windows.Forms.ListBox();
            this.bRemove = new System.Windows.Forms.Button();
            this.LBDate = new System.Windows.Forms.ListBox();
            this.bSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBCount
            // 
            this.LBCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBCount.FormattingEnabled = true;
            this.LBCount.ItemHeight = 15;
            this.LBCount.Location = new System.Drawing.Point(0, 0);
            this.LBCount.Name = "LBCount";
            this.LBCount.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LBCount.Size = new System.Drawing.Size(34, 461);
            this.LBCount.TabIndex = 0;
            // 
            // bAdd
            // 
            this.bAdd.AutoSize = true;
            this.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAdd.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bAdd.Location = new System.Drawing.Point(621, 10);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(74, 68);
            this.bAdd.TabIndex = 1;
            this.bAdd.Text = "Add";
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // tbNoteText
            // 
            this.tbNoteText.AcceptsReturn = true;
            this.tbNoteText.AcceptsTab = true;
            this.tbNoteText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbNoteText.Enabled = false;
            this.tbNoteText.Location = new System.Drawing.Point(293, 0);
            this.tbNoteText.Multiline = true;
            this.tbNoteText.Name = "tbNoteText";
            this.tbNoteText.Size = new System.Drawing.Size(310, 462);
            this.tbNoteText.TabIndex = 2;
            // 
            // bRename
            // 
            this.bRename.Enabled = false;
            this.bRename.Location = new System.Drawing.Point(620, 84);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(75, 23);
            this.bRename.TabIndex = 3;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = true;
            this.bRename.Click += new System.EventHandler(this.bRename_Click);
            // 
            // RenameTB
            // 
            this.RenameTB.Location = new System.Drawing.Point(609, 107);
            this.RenameTB.Name = "RenameTB";
            this.RenameTB.Size = new System.Drawing.Size(100, 23);
            this.RenameTB.TabIndex = 4;
            // 
            // LBNames
            // 
            this.LBNames.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBNames.FormattingEnabled = true;
            this.LBNames.ItemHeight = 15;
            this.LBNames.Location = new System.Drawing.Point(34, 0);
            this.LBNames.Name = "LBNames";
            this.LBNames.Size = new System.Drawing.Size(120, 461);
            this.LBNames.TabIndex = 5;
            this.LBNames.SelectedIndexChanged += new System.EventHandler(this.LBNames_SelectedIndexChanged);
            // 
            // bRemove
            // 
            this.bRemove.Enabled = false;
            this.bRemove.Location = new System.Drawing.Point(621, 136);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(75, 23);
            this.bRemove.TabIndex = 6;
            this.bRemove.Text = "Remove";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            // 
            // LBDate
            // 
            this.LBDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBDate.FormattingEnabled = true;
            this.LBDate.ItemHeight = 15;
            this.LBDate.Location = new System.Drawing.Point(154, 0);
            this.LBDate.Name = "LBDate";
            this.LBDate.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LBDate.Size = new System.Drawing.Size(135, 461);
            this.LBDate.TabIndex = 7;
            // 
            // bSave
            // 
            this.bSave.Enabled = false;
            this.bSave.Location = new System.Drawing.Point(621, 164);
            this.bSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSave.Name = "bSave";
            this.bSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bSave.Size = new System.Drawing.Size(74, 22);
            this.bSave.TabIndex = 8;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 461);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.LBDate);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.LBNames);
            this.Controls.Add(this.RenameTB);
            this.Controls.Add(this.bRename);
            this.Controls.Add(this.tbNoteText);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.LBCount);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LBCount;
        private Button bAdd;
        private TextBox tbNoteText;
        private Button bRename;
        private TextBox RenameTB;
        private ListBox LBNames;
        private Button bRemove;
        private ListBox LBDate;
        private Button bSave;
    }
}