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
            this.textBox1 = new System.Windows.Forms.TextBox();
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
            this.LBCount.ItemHeight = 20;
            this.LBCount.Location = new System.Drawing.Point(0, 0);
            this.LBCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LBCount.Name = "LBCount";
            this.LBCount.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LBCount.Size = new System.Drawing.Size(38, 615);
            this.LBCount.TabIndex = 0;
            // 
            // bAdd
            // 
            this.bAdd.AutoSize = true;
            this.bAdd.BackgroundImage = global::Note_Taking_Application.Properties.Resources.plus;
            this.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.bAdd.Location = new System.Drawing.Point(679, 16);
            this.bAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(85, 91);
            this.bAdd.TabIndex = 1;
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.AcceptsTab = true;
            this.textBox1.Location = new System.Drawing.Point(335, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 581);
            this.textBox1.TabIndex = 2;
            this.textBox1.Enabled = false;
            // 
            // bRename
            // 
            this.bRename.Location = new System.Drawing.Point(678, 128);
            this.bRename.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(86, 31);
            this.bRename.TabIndex = 3;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = true;
            this.bRename.Click += new System.EventHandler(this.bRename_Click);
            this.bRename.Enabled = false;
            // 
            // textBox2
            // 
            this.RenameTB.Location = new System.Drawing.Point(545, 128);
            this.RenameTB.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RenameTB.Name = "textBox2";
            this.RenameTB.Size = new System.Drawing.Size(114, 27);
            this.RenameTB.TabIndex = 4;
            // 
            // LBNames
            // 
            this.LBNames.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBNames.FormattingEnabled = true;
            this.LBNames.ItemHeight = 20;
            this.LBNames.Location = new System.Drawing.Point(38, 0);
            this.LBNames.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LBNames.Name = "LBNames";
            this.LBNames.Size = new System.Drawing.Size(137, 615);
            this.LBNames.TabIndex = 5;
            this.LBNames.SelectedIndexChanged += new System.EventHandler(this.LBNames_SelectedIndexChanged);
            // 
            // bRemove
            // 
            this.bRemove.Location = new System.Drawing.Point(679, 180);
            this.bRemove.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.bRemove.Name = "bRemove";
            this.bRemove.Size = new System.Drawing.Size(86, 31);
            this.bRemove.TabIndex = 6;
            this.bRemove.Text = "Remove";
            this.bRemove.UseVisualStyleBackColor = true;
            this.bRemove.Click += new System.EventHandler(this.bRemove_Click);
            this.bRemove.Enabled = false;
            // 
            // LBDate
            // 
            this.LBDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBDate.FormattingEnabled = true;
            this.LBDate.ItemHeight = 20;
            this.LBDate.Location = new System.Drawing.Point(175, 0);
            this.LBDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LBDate.Name = "LBDate";
            this.LBDate.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.LBDate.Size = new System.Drawing.Size(154, 615);
            this.LBDate.TabIndex = 7;
            // 
            // bSave
            // 
            this.bSave.Location = new System.Drawing.Point(679, 229);
            this.bSave.Name = "bSave";
            this.bSave.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bSave.Size = new System.Drawing.Size(85, 29);
            this.bSave.TabIndex = 8;
            this.bSave.Text = "Save";
            this.bSave.UseVisualStyleBackColor = true;
            this.bSave.Click += new System.EventHandler(this.bSave_Click);
            this.bSave.Enabled = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 615);
            this.Controls.Add(this.bSave);
            this.Controls.Add(this.LBDate);
            this.Controls.Add(this.bRemove);
            this.Controls.Add(this.LBNames);
            this.Controls.Add(this.RenameTB);
            this.Controls.Add(this.bRename);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.LBCount);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
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
        private TextBox textBox1;
        private Button bRename;
        private TextBox RenameTB;
        private ListBox LBNames;
        private Button bRemove;
        private ListBox LBDate;
        private Button bSave;
    }
}