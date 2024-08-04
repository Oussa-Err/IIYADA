using gestionCabinie.Utils;
using System;
using System.Windows.Forms;

namespace gestionCabinie
{
    public partial class FormMedicament : Form
    {
        private Doctor doctor;
        public FormMedicament(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //this.Doctor.Currentpatient.Cuuerntconsultation.ajouterM(new Medicament(int.Parse(this.txtIdM.Text.ToString()), this.txtNom.Text));
                //this.Doctor.Currentpatient.Cuuerntconsultation.ajouterM(new Medicament(int.Parse(this.txtIdM.Text.ToString()), this.txtNom.Text));
                //this.Doctor.ajouterm(new Medicament(int.Parse(this.txtIdM.Text.ToString()), this.txtNom.Text));
                this.doctor.Currentpatient = new Patient();
                this.doctor.Currentpatient.Cuuerntconsultation = new Consultation();
                this.doctor.Currentpatient.Cuuerntconsultation.ajouterM(new Medicament(int.Parse(this.txtIdM.Text.ToString()), this.txtNom.Text));
                MessageBox.Show("le medicament est ajouter");
                this.txtIdM.Text = string.Empty;
                this.txtNom.Text = string.Empty;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            this.doctor.Currentpatient = new Patient();
            this.doctor.Currentpatient.Cuuerntconsultation = new Consultation();
            this.doctor.Currentpatient.Cuuerntconsultation.modifierMd(new Medicament(int.Parse(txtIdM.Text), txtNom.Text));
        }

        private void txtsaerch_Click(object sender, EventArgs e)
        {
            this.guna2GroupBox2.Visible = true;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSearch.Text != string.Empty)
                {
                    this.doctor.Currentpatient = new Patient();
                    this.doctor.Currentpatient.Cuuerntconsultation = new Consultation();
                    this.doctor.Currentpatient.Cuuerntconsultation.CurrentMedicament = new Medicament();
                    this.doctor.Currentpatient.Cuuerntconsultation.saerchMD(this.txtSearch.Text);
                    //int.Parse( this.txtIdM .Text.ToString())= this.doctor.Currentpatient.Cuuerntconsultation.CurrentMedicament.Id;
                    this.txtNom.Text = this.doctor.Currentpatient.Cuuerntconsultation.CurrentMedicament.Nom;
                    this.txtSearch.Text = string.Empty;
                }
                else
                {
                    MessageBox.Show("Entry your medicament name");
                    txtSearch.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.guna2GroupBox2.Visible = false;
            this.txtIdM.Text = string.Empty;
            this.txtNom.Text = string.Empty;
        }
        private void gérerConsultationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormConsultation formConsultation = new FormConsultation(doctor);
            FormPositionUtil.OpenNewForm(this, formConsultation);
            this.Close();
        }
        private void gérerMédicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedicament formMidecament = new FormMedicament(doctor);
            FormPositionUtil.OpenNewForm(this, formMidecament);
            this.Close();
        }
        private void parcourirConsultationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDTConsultation formDTConsultation = new FormDTConsultation(doctor);
            FormPositionUtil.OpenNewForm(this, formDTConsultation);
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
