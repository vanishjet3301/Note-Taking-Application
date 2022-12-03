using System.Drawing;
using static System.Net.Mime.MediaTypeNames;

namespace Note_Taking_Application
{
    public partial class Form1 : Form
    {
        string NoteName = "New Note";
        bool BeingRemoved = false;
        bool BeingRenamed = false;
        private void bAva(bool a)
        {
            textBox1.Enabled = a;
            bSave.Enabled = a;
            bRename.Enabled = a;
            bRemove.Enabled = a;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {   
            void Add(int a)
            {
                LBCount.Items.Add(($"{LBNames.Items.Count + 1}."));
                LBNames.Items.Add(NoteName + (a));
                LBDate.Items.Add(DateTime.Now);
                File.AppendAllText(@".\NNamesStorage.txt", Environment.NewLine + NoteName + (a));
            }
            if (File.Exists(@"NNamesStorage.txt"))
            {
                int[] DefaultNameIndexes;
                int NumofIndexes = 0;
                int j = 0;
                string[] ls = File.ReadAllLines(@".\NNamesStorage.txt");
                for (int i = 0; i < ls.Length; i++)
                {
                    if (ls[i].Contains("New Note")) { NumofIndexes++; }
                }
                DefaultNameIndexes = new int[NumofIndexes];
                for (int i = 0; i < ls.Length; i++)
                {
                    if (ls[i].Contains("New Note"))
                    {
                        string[] subs = ls[i].Split("New Note", StringSplitOptions.RemoveEmptyEntries);
                        if(subs.Length == 1)
                        {
                            if (int.TryParse(subs[0], out DefaultNameIndexes[j])) { j++; }
                        }
                    }
                }
                DefaultNameIndexes = DefaultNameIndexes.Where(x => !(x == 0)).ToArray();
                Array.Sort(DefaultNameIndexes);
                for(int i = 0; i < DefaultNameIndexes.Length; i++)
                {
                    if(i + 1 < DefaultNameIndexes.Length) 
                    {
                        if(DefaultNameIndexes[i] + 1 != DefaultNameIndexes[i + 1])
                        {
                            LBCount.Items.Add(($"{LBNames.Items.Count + 1}."));
                            LBNames.Items.Add(NoteName + (DefaultNameIndexes[i] + 1));
                            LBDate.Items.Add(DateTime.Now);
                            File.AppendAllText(@".\NNamesStorage.txt", Environment.NewLine + NoteName + (DefaultNameIndexes[i] + 1));
                            return;
                        }
                        else if (DefaultNameIndexes[0] != 1)
                        {
                            LBCount.Items.Add(($"{LBNames.Items.Count + 1}."));
                            LBNames.Items.Add(NoteName + 1);
                            LBDate.Items.Add(DateTime.Now);
                            File.AppendAllText(@".\NNamesStorage.txt", Environment.NewLine + NoteName + 1);
                            return;
                        }
                    }
                }
                
            }
            LBCount.Items.Add(($"{LBNames.Items.Count + 1}."));
            LBNames.Items.Add(NoteName + (LBNames.Items.Count + 1));
            LBDate.Items.Add(DateTime.Now);
            File.AppendAllText(@".\NNamesStorage.txt", Environment.NewLine + NoteName + LBNames.Items.Count);
        }

        private void bRename_Click(object sender, EventArgs e)
        {
            DialogResult result = DialogResult.Yes;
            BeingRenamed = true;
            int ind = LBNames.SelectedIndex;
            if (RenameTB.Text == "") 
            { 
                MessageBox.Show("Enter at least one symbol");
                return;
            }
            bool StringExists = false;
            
            string[] ls = File.ReadAllLines("NNamesStorage.txt");
            for (int i = 0; i < ls.Length; i++)
            {
                if (ls[i] == RenameTB.Text) { StringExists = true; break; }

            }
            if (StringExists)
            {
                string LBNameTemp = LBNames.SelectedItem.ToString();
                result = MessageBox.Show(
                "File with this name already exists and will be removed. Continue?", "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1);
                if (result == DialogResult.Yes)
                {
                    LBNames.SelectedIndex = LBNames.Items.IndexOf(RenameTB.Text);
                    bRemove_Click(sender, e);
                    LBNames.SelectedIndex = LBNames.Items.IndexOf(LBNameTemp);
                    ind = LBNames.SelectedIndex;
                }

            }
            
            if(result == DialogResult.Yes)
            {
                
                if (File.Exists(@".\Notes\" + LBNames.SelectedItem + ".txt"))
                {
                    File.Move(@".\Notes\" + LBNames.SelectedItem + ".txt", @".\Notes\" + RenameTB.Text + ".txt");
                    ls = File.ReadAllLines("NNamesStorage.txt");
                    for (int i = 0; i < ls.Length; i++)
                    {
                        if (ls[i].Contains(LBNames.SelectedItem.ToString())) { ls[i] = RenameTB.Text; break; }
                            
                    }
                    
                    File.WriteAllLines("NNamesStorage.txt", ls);
                }

                LBNames.Items.RemoveAt(ind);
                LBNames.Items.Insert(ind, RenameTB.Text);
                
            }
            BeingRenamed = false;
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            int ind = LBNames.SelectedIndex;
            if(File.Exists(@".\Notes\" + LBNames.SelectedItem + ".txt"))
            {
                File.Delete(@".\Notes\" + (LBNames.SelectedItem + ".txt"));
            }
            var ls = File.ReadAllLines(@".\NNamesStorage.txt");
            if (ls.Contains(LBNames.SelectedItem))
            {
                var newLs = ls.Where(line => !line.Contains(LBNames.SelectedItem.ToString()));
                File.WriteAllLines(@".\NNamesStorage.txt", newLs);
                
            }
            BeingRemoved = true;
            LBNames.Items.RemoveAt(ind);
            LBDate.Items.RemoveAt(ind);
            LBCount.Items.Clear();
            for (int i = 0; i < LBNames.Items.Count; i++)
            {
                LBCount.Items.Add($"{i + 1}.");
            }
            bAva(false);
            BeingRemoved = false;
        }

        private void LBNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(BeingRemoved || BeingRenamed) { return; }
            bAva(true);
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