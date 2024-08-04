using gestionCabinie.Utils;
using System;
using System.Windows.Forms;

namespace gestionCabinie
{
    public partial class FormDoctor : Form
    {
        private Form currentChildForm;
        private Doctor doctor;
        public FormDoctor(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void FormDocotr_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.doctor.Connection.Close();
        }

        private void BtnConsultation_Click(object sender, EventArgs e)
        {
            FormConsultation formConsultation = new FormConsultation(doctor);
            formConsultation.Show();
            this.Close();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            FormMedicament formMidecament = new FormMedicament(doctor);
            formMidecament.Show();
            this.Close();
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            FormDTConsultation formDTConsultation = new FormDTConsultation(doctor);
            formDTConsultation.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormDoctor_Load(object sender, EventArgs e)
        {

        }

        private void gérerConsultationToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        //private void OpenChildForm(Form childForm)
        //{
        //    if (currentChildForm != null)
        //    { currentChildForm.Close(); }
        //    childForm.TopLevel = false;
        //    childForm.Dock = DockStyle.Fill;
        //    panelConsultation.Controls.Add(childForm);
        //    childForm.BringToFront();
        //    childForm.Show();
        //}

        //private void iconButton1_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new FormMidecament(doctor));
        //}

        //private void btnhome_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new FormHome());
        //}

        //private void iconButton2_Click(object sender, EventArgs e)
        //{
        //    OpenChildForm(new FormDTConsultation(doctor));
        //}

        //private void iconButton2_Click_1(object sender, EventArgs e)
        //{
        //    OpenChildForm(new FormDTConsultation(doctor));
        //}
    }
}
