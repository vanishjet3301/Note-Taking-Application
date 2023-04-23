using DataManagement;

namespace Note_Taking_Application
{
    public partial class Form1 : Form
    {
        List<NoteModel> Notes;
        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateForm()
        {
            Notes = DataAccess.LoadNotes();
            dataGridView.DataSource = Notes;
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells["NoteNumber"].Value = row.Index + 1;
            }
            dataGridView.ClearSelection();
        }
        private void bAdd_Click(object sender, EventArgs e)
        {
            DataAccess.AddNote(new DataManagement.NoteModel());
            UpdateForm();
        }

        private void bRemove_Click(object sender, EventArgs e)
        {
            List<int> ids = new List<int>();
            foreach (DataGridViewCell cell in dataGridView.SelectedCells)
            {
                ids.Add((int)cell.OwningRow.Cells["Id"].Value);
            }

            DataAccess.DeleteNote(ids);
            UpdateForm();
        }

        private void bSave_Click(object sender, EventArgs e)
        {
            int RowIndex = dataGridView.CurrentCell.RowIndex;
            int Id = (int)dataGridView.Rows[RowIndex].Cells["Id"].Value;
            string EditTime = DateTime.Now.ToString();
            string Text = tbNoteText.Text;
            DataAccess.SaveNoteText(Id, Text, EditTime);
            UpdateForm();
            dataGridView.CurrentCell = dataGridView.Rows[RowIndex].Cells["NoteName"];
            dataGridView.Rows[RowIndex].Selected = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Notes = DataAccess.LoadNotes();
            dataGridView.Columns.Add("NoteNumber", "№");
            dataGridView.DataSource = Notes;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells["NoteNumber"].Value = row.Index + 1;
            }
            dataGridView.AutoGenerateColumns = true;

            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["Text"].Visible = false;
            dataGridView.Columns["NoteNumber"].Width = 25;
            dataGridView.Columns["NoteNumber"].ReadOnly = true;
            dataGridView.Columns["NoteName"].HeaderText = "Note Name";
            dataGridView.Columns["NoteName"].Width = 110;
            dataGridView.Columns["EditTime"].HeaderText = "Edit Time";
            dataGridView.Columns["EditTime"].Width = 108;
            dataGridView.Columns["EditTime"].DefaultCellStyle.Format = "MM/dd/yyyy hh:mm tt";
            dataGridView.Columns["EditTime"].ReadOnly = true;
            dataGridView.ClearSelection();
            tbNoteText.Text = string.Empty;
        }

        private void dataGridView_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            dataGridView.ClearSelection();
        }
        private void dataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView.CurrentCell.Selected = true;
            int RowIndex = dataGridView.CurrentRow.Index;
            int Id = (int)dataGridView.Rows[RowIndex].Cells["Id"].Value;
            string NewNoteName = dataGridView.Rows[RowIndex].Cells["NoteName"].Value.ToString();
            DataAccess.RenameNote(Id, NewNoteName);
            dataGridView.ClearSelection();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 1)
            {
                tbNoteText.Enabled = true;
                bSave.Enabled = true;
                tbNoteText.Text = (string)dataGridView.CurrentRow.Cells["Text"].Value;
            }
            else
            {
                tbNoteText.Text = null;
                tbNoteText.Enabled = false;
                bSave.Enabled = false;
            }
        }
    }
}