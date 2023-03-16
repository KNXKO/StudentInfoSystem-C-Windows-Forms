using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lukas_Lechovic_06
{
    public partial class FormStudent : Form
    {
        private readonly FormStudentInfo _parent;
        public string id, Meno, Priezvisko, Datum_narodenia, Email, Telefon, Bydlisko, PSC;
        public FormStudent(FormStudentInfo parent)
        {
            InitializeComponent();
            _parent = parent;
        }

        public void UpdateInfo()
        {
            lbltext.Text = "Zmeniť údaje";
            btnUlozit.Text = "Zmeniť";
            txtMeno.Text = Meno;
            txtPriezvisko.Text = Priezvisko;
            txtDate.Text = Datum_narodenia;
            txtEmail.Text = Email;
            txtTelefon.Text = Telefon;
            txtBydlisko.Text = Bydlisko;
            txtPsc.Text = PSC;

        }

        public void SaveInfo()
        {
            lbltext.Text = "Pridať študenta";
            btnUlozit.Text = "Pridať";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void txtTelefon_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lbltext_Click(object sender, EventArgs e)
        {

        }

        public void Clear()
        {
            txtMeno.Text = txtPriezvisko.Text = txtEmail.Text = txtTelefon.Text = txtBydlisko.Text = txtPsc.Text = String.Empty;
        }

        private void btnUlozit_Click(object sender, EventArgs e)
        {
            if(txtMeno.Text.Trim().Length < 3 && txtPriezvisko.Text.Trim().Length < 3 && txtEmail.Text.Trim().Length < 3 && txtTelefon.Text.Trim().Length < 3 && txtBydlisko.Text.Trim().Length < 3 && txtPsc.Text.Trim().Length < 3)
            {
                MessageBox.Show("Všetky položky musia byť vyplnené");
                return;
            }
            if(btnUlozit.Text == "Pridať")
            {
                Student std = new Student(txtMeno.Text.Trim(), txtPriezvisko.Text.Trim(), txtDate.Value, txtEmail.Text.Trim(), txtTelefon.Text.Trim(), txtBydlisko.Text.Trim(), txtPsc.Text.Trim());
                DbStudent.AddStudent(std);
                Clear();
            }
            if (btnUlozit.Text == "Zmeniť")
            {
                Student std = new Student(txtMeno.Text.Trim(), txtPriezvisko.Text.Trim(), txtDate.Value, txtEmail.Text.Trim(), txtTelefon.Text.Trim(), txtBydlisko.Text.Trim(), txtPsc.Text.Trim());
                DbStudent.UpdateStudent(std, id);
            }
            _parent.Display();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormStudent_Load(object sender, EventArgs e)
        {

        }

        private void txtPsc_TextChanged(object sender, EventArgs e)
        {
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
