namespace Lukas_Lechovic_06
{
    public partial class FormStudentInfo : Form
    {
        FormStudent form;
        public FormStudentInfo()
        {
            InitializeComponent();
            form = new FormStudent(this);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Paint(object sender, EventArgs e)
        {

        }

        private void dataGridView_CellContentClick(object sender, EventArgs e)
        {

        }

        public void Display()
        {
            DbStudent.DisplayAndSearch("SELECT ID, Meno, Priezvisko, Datum_narodenia, Email, Telefon, Bydlisko, PSC FROM student_info", dataGridView);
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            form.Clear();
            form.SaveInfo();
            form.ShowDialog();  
        }

        private void FormStudentInfo_Shown(object sender, EventArgs e)
        {
            Display();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            DbStudent.DisplayAndSearch("SELECT ID, Meno, Priezvisko, Datum_narodenia, Email, Telefon, Bydlisko, PSC FROM student_info WHERE Meno LIKE'%" + txtSearch.Text + "%' OR Priezvisko LIKE'%" + txtSearch.Text + "%' OR Datum_narodenia LIKE'%" + txtSearch.Text + "%' OR Email LIKE'%" + txtSearch.Text + "%' OR Telefon LIKE'%" + txtSearch.Text + "%' OR Telefon LIKE'%" + txtSearch.Text + "%' OR Bydlisko LIKE '%" + txtSearch.Text + "%' OR PSC LIKE '%" + txtSearch.Text + "%'", dataGridView);
        }
         
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                form.Clear();
                form.id = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                form.Meno = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                form.Priezvisko = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
                form.Datum_narodenia = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
                form.Email = dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
                form.Telefon = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
                form.Bydlisko = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
                form.PSC= dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
                form.UpdateInfo();
                form.ShowDialog();
                return;
            }
            if (e.ColumnIndex == 1)
            {
                if (MessageBox.Show("Naozaj chcete vymazaù ötudenta?", " Information ", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    DbStudent.DeleteStudent(dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    Display();
                }

            }
            return;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}