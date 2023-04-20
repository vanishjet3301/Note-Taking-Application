using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using DataManagement;
using static System.Net.Mime.MediaTypeNames;

/*  Bimba
 *  ToDo
 *  1. AddingNotes, 2. RenamingNotes, 3. Removing, 4. Saving
 *  Issues
 *  
 */

namespace Note_Taking_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        object CellValue;
        private void LoadNotesToDataGridView()
        {
            DataTable table = new DataTable();
            using (IDbConnection connection = new SQLiteConnection())
            {

            }
        }
        private void bAdd_Click(object sender, EventArgs e)
        {

        }

        private void bRename_Click(object sender, EventArgs e)
        {


        }

        private void bRemove_Click(object sender, EventArgs e)
        {

        }

        private void bSave_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView.DataSource = DataAccess.LoadNotes();
            dataGridView.AutoGenerateColumns = true;
            dataGridView.Columns["NoteName"].HeaderText = "Note Name";
            //dataGridView.Columns["NoteName"].ReadOnly = true;
            dataGridView.Columns["EditTime"].HeaderText = "Edit Time";
            dataGridView.Columns["EditTime"].Width = 120;
            dataGridView.Columns["EditTime"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
            dataGridView.ClearSelection();
            tbNoteText.Text = string.Empty;
        }

        private void dataGridView_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.Columns[e.ColumnIndex].Name == "EditTime")
            {
                dataGridView.BeginInvoke(new Action(() =>
                {
                    dataGridView.CurrentCell = null;
                }));
                return;
            }
            DataGridViewCell cell = dataGridView.CurrentCell;
            CellValue = cell.Value;
            if (CellValue != null)
            {
                tbNoteText.Text = DataAccess.ReadNoteText(CellValue.ToString());
            }
        }

        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.CurrentCell.Value == null)
            {
                MessageBox.Show("Enter at least one symbol");
                dataGridView.BeginEdit(true); return;
            }
        }
    }
}