using System.Drawing;

namespace Note_Taking_Application
{
    public partial class Form1 : Form
    {
        string NoteName = "New Note";
        public Form1()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {   
            LBCount.Items.Add(($"{LBNames.Items.Count + 1}."));
            LBNames.Items.Add(NoteName + (LBNames.Items.Count + 1));
            LBDate.Items.Add(DateTime.Now);
            File.AppendAllText(@".\NNamesStorage.txt", Environment.NewLine + NoteName + LBNames.Items.Count);
        }

        private void bRename_Click(object sender, EventArgs e)
        {
            int ind = LBNames.SelectedIndex; // ren
            if (ind != -1)
            {
                if (textBox2.Text == "")
                {
                    MessageBox.Show("Enter at least one symbol");
                }
                else
                {
                    LBNames.Items.RemoveAt(ind);
                    LBNames.Items.Insert(ind, textBox2.Text);
                }
            }
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            LBNames.Items.RemoveAt(LBNames.SelectedIndex);
            LBDate.Items.RemoveAt(LBNames.SelectedIndex);
            LBCount.Items.Clear();
            for (int i = 0; i < LBNames.Items.Count; i++)
            {
                LBCount.Items.Add($"{i + 1}.");
            }
            //!!!!!!!!!!!!! remove
        }

        private void LBNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Enabled = true;
            bSave.Enabled = true;
            bRename.Enabled = true;
            bRemove.Enabled = true;
            if (Directory.Exists("Notes"))
            {
                textBox1.Text = "";
                int i;
                FileStream FS = null;
                try
                {
                    FS = new FileStream(@".\Notes\" + LBNames.SelectedItem + ".txt", FileMode.OpenOrCreate);
                }
                catch
                {
                    MessageBox.Show("Err inCH");
                }

                try
                {
                    do
                    {
                        i = FS.ReadByte();
                        if (i != -1) textBox1.Text += (char)i;
                    }
                    while (i != -1);
                }
                finally
                {
                    FS.Close();
                }
            }
        }

        private void bSave_Click(object sender, EventArgs e) //!!date
        {
            DialogResult result = MessageBox.Show(
                "Save changes?", "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);

            if(result == DialogResult.Yes)
            {
                FileStream FS = null;
                char[] text = textBox1.Text.ToCharArray();
                try
                {
                    FS = new FileStream(@".\Notes\" + LBNames.SelectedItem.ToString() + ".txt", FileMode.Create);

                    for(int i = 0; i < text.Length; i++) FS.WriteByte((byte) text[i]);
                }
                catch (IOException exc)
                {
                    Console.WriteLine("I/O Error:\n" + exc.Message);
                }
                finally
                {
                    if (FS != null) FS.Close();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("Notes")) { Directory.CreateDirectory("Notes"); }
            if (File.Exists("NNamesStorage.txt"))
            {
                var ls = File.ReadAllLines("NNamesStorage.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
                File.WriteAllLines("NNamesStorage.txt", ls);
                string[] lines = File.ReadAllLines(@".\NNamesStorage.txt");

                foreach(string line in lines)
                {
                    NoteName = line;
                    LBCount.Items.Add(($"{LBNames.Items.Count + 1}."));
                    LBNames.Items.Add(NoteName);
                    LBDate.Items.Add(DateTime.Now);
                }
                NoteName = "New Note";
            }
            else using (File.Create("NNamesStorage.txt")) ;
        }
    }//props
}