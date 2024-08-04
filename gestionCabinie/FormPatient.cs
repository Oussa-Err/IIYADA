using System;
using System.Windows.Forms;

namespace gestionCabinie
{
    public partial class FormPatient : Form
    {

         Secretaire secretaire;
        public FormPatient(Secretaire secretaire)
        {
            InitializeComponent();
            this.secretaire = secretaire;
            FormBorderStyle = FormBorderStyle.Sizable;
        }
        private void vidertxt()
        {
            txtCin.Text = string.Empty;
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtTel.Text = string.Empty;
            txtAdress.Text = string.Empty;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.guna2GroupBox1.Visible = true;
            try
            {
                this.secretaire.searchPt(this.txtsearch.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.guna2GroupBox1.Visible = false;
            this.txtCin.Text = string.Empty;
            this.txtNom.Text = string.Empty;
            this.txtPrenom.Text = string.Empty;
            this.txtAdress.Text = string.Empty;
            this.txtTel.Text = string.Empty;
            this.txtsearch.Text = string.Empty;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                this.secretaire.Ajouter(new Patient(this.txtCin.Text, this.txtNom.Text, this.txtPrenom.Text, this.txtAdress.Text, this.txtTel.Text));
                MessageBox.Show("le patient est Ajouter");
                this.vidertxt();
                this.secretaire.chargerPatient();
                //this.txtCin.Text = string.Empty;
                //this.txtNom.Text= string.Empty;
                //this.txtPrenom.Text= string.Empty;
                //this.txtTel.Text= string.Empty;
                //this.txtAdress.Text=string.Empty;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormPatient_Load(object sender, EventArgs e)
        {
            try
            {
                this.guna2DataGridView1.DataSource = this.secretaire.chargerPatient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("are you sure to delete this patient", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return; //stop
                }
                //this.secretaire.suppeimerPt(this.secretaire.Currentpatient.Cin);
                this.secretaire.suppeimerPt(this.secretaire.Currentpatient.Cin);
                this.vidertxt();
                this.secretaire.chargerPatient();
                //this.secretaire.suppeimerPt(this.txtCin.Text);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtsearch.Text == string.Empty)
                {
                    MessageBox.Show("entry your CIN for search");
                    this.txtsearch.Focus();
                }
                else
                {
                    this.secretaire.searchPt(this.txtsearch.Text);
                    this.txtCin.Text = this.secretaire.Currentpatient.Cin;
                    this.txtNom.Text = this.secretaire.Currentpatient.Nom;
                    this.txtPrenom.Text = this.secretaire.Currentpatient.Prenom;
                    this.txtAdress.Text = this.secretaire.Currentpatient.Adress;
                    this.txtTel.Text = this.secretaire.Currentpatient.Tel;
                }
                //if (this.txtsearch.Text == string.Empty)
                //{
                //    MessageBox.Show("entry your CIN for search");
                //    this.txtsearch.Focus();
                //}
                //else if (this.secretaire.searchPt(this.txtsearch.Text)==)
                //{
                //    this.secretaire.searchPt(this.txtsearch.Text);
                //    this.txtCin.Text = this.secretaire.Currentpatient.Cin;
                //    this.txtNom.Text = this.secretaire.Currentpatient.Nom;
                //    this.txtPrenom.Text = this.secretaire.Currentpatient.Prenom;
                //    this.txtAdress.Text = this.secretaire.Currentpatient.Adress;
                //    this.txtTel.Text = this.secretaire.Currentpatient.Tel;
                //}
                //else
                //{
                //    MessageBox.Show("not find CIN");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("are you sure to update this patient", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return; //stop
                }
                this.secretaire.Currentpatient.modifierPt(new Patient(this.txtCin.Text, this.txtNom.Text, this.txtPrenom.Text, this.txtAdress.Text, this.txtTel.Text));
                //this.secretaire.chargerPatient();
                MessageBox.Show("le patient est bien modifier !");
                this.vidertxt();
                this.secretaire.chargerPatient();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void FormPatient_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.secretaire.Connection.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
