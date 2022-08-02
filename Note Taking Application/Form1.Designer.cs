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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.LBNames = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.LBDate = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.LBCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBCount.FormattingEnabled = true;
            this.LBCount.ItemHeight = 15;
            this.LBCount.Location = new System.Drawing.Point(0, 0);
            this.LBCount.Name = "listBox1";
            this.LBCount.Size = new System.Drawing.Size(34, 461);
            this.LBCount.TabIndex = 0;
            // 
            // bAdd
            // 
            this.bAdd.AutoSize = true;
            this.bAdd.BackgroundImage = global::Note_Taking_Application.Properties.Resources.plus;
            this.bAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bAdd.ForeColor = System.Drawing.SystemColors.Control;
            this.bAdd.Location = new System.Drawing.Point(594, 12);
            this.bAdd.Name = "bAdd";
            this.bAdd.Size = new System.Drawing.Size(74, 68);
            this.bAdd.TabIndex = 1;
            this.bAdd.UseVisualStyleBackColor = true;
            this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(295, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(202, 437);
            this.textBox1.TabIndex = 2;
            // 
            // bRename
            // 
            this.bRename.Location = new System.Drawing.Point(593, 96);
            this.bRename.Name = "bRename";
            this.bRename.Size = new System.Drawing.Size(75, 23);
            this.bRename.TabIndex = 3;
            this.bRename.Text = "Rename";
            this.bRename.UseVisualStyleBackColor = true;
            this.bRename.Click += new System.EventHandler(this.bRename_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(477, 96);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            // 
            // listBox2
            // 
            this.LBNames.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBNames.FormattingEnabled = true;
            this.LBNames.ItemHeight = 15;
            this.LBNames.Location = new System.Drawing.Point(34, 0);
            this.LBNames.Name = "listBox2";
            this.LBNames.Size = new System.Drawing.Size(120, 461);
            this.LBNames.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 135);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Remove";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listBox3
            // 
            this.LBDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.LBDate.FormattingEnabled = true;
            this.LBDate.ItemHeight = 15;
            this.LBDate.Location = new System.Drawing.Point(154, 0);
            this.LBDate.Name = "listBox3";
            this.LBDate.Size = new System.Drawing.Size(135, 461);
            this.LBDate.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 461);
            this.Controls.Add(this.LBDate);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LBNames);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bRename);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bAdd);
            this.Controls.Add(this.LBCount);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox LBCount;
        private Button bAdd;
        private TextBox textBox1;
        private Button bRename;
        private TextBox textBox2;
        private ListBox LBNames;
        private Button button1;
        private ListBox LBDate;
    }
}