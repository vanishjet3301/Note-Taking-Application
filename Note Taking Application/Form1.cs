namespace Note_Taking_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            LBCount.Items.Add(($"{LBNames.Items.Count + 1}."));
            LBNames.Items.Add("New Note");
            LBDate.Items.Add(DateTime.Now);
        }

        private void bRename_Click(object sender, EventArgs e)
        {
            int ind = LBNames.SelectedIndex;
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

        private void button1_Click(object sender, EventArgs e)
        {
            int ind = LBNames.SelectedIndex;
            if (ind != -1)
            {           
                LBNames.Items.RemoveAt(ind);
                LBCount.Items.Clear();
                for (int i = 0; i < LBNames.Items.Count; i++)
                {
                    LBCount.Items.Add($"{i + 1}.");
                }
            }
        }
    }
}