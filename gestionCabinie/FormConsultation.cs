using gestionCabinie.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace gestionCabinie
{
    public partial class FormConsultation : Form
    {
        private Doctor doctor;
        private bool isFormLoaded = false;
        public SqlConnection conn=DatabaseConnection.connection;
        public FormConsultation(Doctor doctor)
        {
            InitializeComponent();
            this.doctor = doctor;
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void btnSearche_Click(object sender, EventArgs e)
        {
            this.guna2GroupBox1.Visible = true;
        }
        //public bool PatientExiste(string cin)
        //{
        //    //using (SqlConnection conn = new SqlConnection("Data Source=ilyass;Initial Catalog=Cabinie;Integrated Security=True;"))
            
        //        //conn.Open();
        //        SqlCommand cmd = new SqlCommand("SELECT COUNT(*) FROM patients WHERE CIN = @CIN",this.conn);
        //        {
        //            cmd.Parameters.AddWithValue("@CIN", cin);
        //            this.conn.Open();
        //            int count = (int)cmd.ExecuteScalar();
        //            return count > 0;
                   
        //        }
                
                
               
            
           
        //}
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
                //try
                //{
                    // Vérifiez si le patient existe
                    //if (!this.PatientExiste(this.CbCin.Text))
                    //{
                    //    MessageBox.Show("Le patient avec le CIN spécifié n'existe pas.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //    return;
                    //}

                    // Ajoutez la consultation si le patient existe
                    this.doctor.ajouter(new Consultation(int.Parse(this.txtIdClt.Text), this.CbCin.Text, this.dateClt.Value, this.txtDescClt.Text, this.dateRendVous.Value));
                    MessageBox.Show("La consultation a été ajoutée avec succès.");

                    // Réinitialiser les champs
                    this.txtIdClt.Text = string.Empty;
                    this.dateClt.Value = DateTime.Now;
                    this.txtDescClt.Text = string.Empty;
                    this.dateRendVous.Value = DateTime.Now;
                    this.txtIdClt.Focus();
                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}
                //this.doctor.ajouter(new Consultation(int.Parse(this.txtIdClt.Text), this.CbCin.Text, this.dateClt.Value, this.txtDescClt.Text, this.dateRendVous.Value));
                //MessageBox.Show("la cansultation est Ajouter");
                //this.txtIdClt.Text = string.Empty;
                //this.dateClt.Text = string.Empty;
                //this.txtDescClt.Text = string.Empty;
                //this.dateRendVous.Text = string.Empty;
                //this.txtIdClt.Focus();
                //MessageBox.Show("consulations ADD");
                //txtIdClt.Text=string.Empty;
                //txtDescClt.Text=string.Empty;
           
        }

        private void FormConsultation_Load(object sender, EventArgs e)
        {
            var patients = this.doctor.chargerPatient();
            if (patients == null || patients.Rows.Count == 0)
            {
                MessageBox.Show("No patients found.");
                return;
            }

            this.CbCin.DataSource = patients;

            //if (this.CbCin.SelectedIndex is int)
            //{ 

            //    this.CbCin.DataSource = this.doctor.chargerPatient();
            this.CbCin.DisplayMember = "CIN";
                this.CbCin.ValueMember = "CIN";
                this.guna2DataGridView1.ReadOnly = true;
                isFormLoaded = true;
                this.doctor.Currentpatient = new Patient();
                this.doctor.Currentpatient.Cuuerntconsultation = new Consultation();
                this.doctor.Currentpatient.Cuuerntconsultation.CurrentMedicament = new Medicament();
                this.guna2ComboBox1.DataSource = this.doctor.Currentpatient.Cuuerntconsultation.chrgermedicament();
                this.guna2ComboBox1.DisplayMember = "nom";
                this.guna2ComboBox1.ValueMember = "idM";
            



        }

        private void CbCin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!isFormLoaded || this.CbCin.SelectedIndex < 0) return;

            try
            {

                var selectedCIN = this.CbCin.SelectedValue?.ToString();
                if (string.IsNullOrEmpty(selectedCIN))
                {
                    MessageBox.Show("Sélection non valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                this.doctor.Currentpatient = new Patient(selectedCIN);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // Check if the form is fully loaded before executing the code
            //if (isFormLoaded) return;

            //try
            //{
            //    this.doctor.Currentpatient = new Patient(this.CbCin.SelectedValue.ToString());
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (DatabaseConnection.connection.State == System.Data.ConnectionState.Closed)
                {
                    DatabaseConnection.connection.Open();
                }
                DialogResult dialog = MessageBox.Show("do you sure to delete this patient", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return; //stop
                }
                this.doctor.Currentpatient.suppeimeCLTt(Int32.Parse(txtIdClt.Text.ToString()));
                //this.doctor.Currentpatient.suppeimeCLTt(doctor.Currentpatient.Cuuerntconsultation.IdClt);
                this.txtIdClt.Text = string.Empty;
                this.CbCin.Text = string.Empty;
                this.dateClt.Text = string.Empty;
                this.dateRendVous.Text = string.Empty;
                this.txtDescClt.Text = string.Empty;
                this.txtIdClt.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void guna2GroupBox2_Click(object sender, EventArgs e)
        {
            //this.doctor.Currentpatient = new Patient();
            //this.doctor.Currentpatient.Cuuerntconsultation = new Consultation();
            this.guna2ComboBox1.DataSource = this.doctor.Currentpatient.Cuuerntconsultation.chrgermedicament();
            this.guna2ComboBox1.DisplayMember = doctor.Currentpatient.Cuuerntconsultation.Medicaments.Columns[0].ColumnName;
            this.guna2ComboBox1.DisplayMember = "nom";
            this.guna2ComboBox1.ValueMember = doctor.Currentpatient.Cuuerntconsultation.Medicaments.Columns[1].ColumnName;
            this.guna2ComboBox1.ValueMember = "idM";
        }

        private void btnMedicaments_Click(object sender, EventArgs e)
        {
            this.guna2GroupBox2.Visible = true;
            this.doctor.Currentpatient = new Patient();
            this.doctor.Currentpatient.Cuuerntconsultation = new Consultation();
            this.guna2ComboBox1.DataSource = this.doctor.Currentpatient.Cuuerntconsultation.chrgermedicament();
            this.guna2ComboBox1.DisplayMember = "nom";
            this.guna2ComboBox1.ValueMember = "idM";
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialog = MessageBox.Show("do you update this cansultation ?", "confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialog == DialogResult.No)
                {
                    return; //stop
                }
                this.doctor.Currentpatient.modifierCLt(new Consultation(Int32.Parse(this.txtIdClt.Text.ToString()), this.CbCin.Text, this.dateClt.Value, this.txtDescClt.Text, this.dateRendVous.Value));
                this.txtIdClt.Text = string.Empty;
                this.dateClt.Text = string.Empty;
                this.txtDescClt.Text = string.Empty;
                this.dateRendVous.Text = string.Empty;
                this.txtIdClt.Focus();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {

                this.doctor.Currentpatient.searchClt(txtSearche.Text);
                this.guna2DataGridView1.DataSource = this.doctor.Currentpatient.Consultations;

                //int.Parse(this.txtIdClt.Text.ToString())=this.doctor.Currentpatient.Cuuerntconsultation.IdClt;
                //this.CbCin.Text = this.doctor.Currentpatient.Cin;
                //this.dateClt.Value = this.doctor.Currentpatient.Cuuerntconsultation.Date;
                //this.txtDescClt.Text = this.doctor.Currentpatient.Cuuerntconsultation.Descreption;
                //this.dateRendVous.Value = this.doctor.Currentpatient.Cuuerntconsultation.DateRendevous;

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnQueter_Click(object sender, EventArgs e)
        {
            this.guna2GroupBox1.Visible = false;
            this.txtIdClt.Text = string.Empty;
            this.CbCin.Text = string.Empty;
            this.dateClt.Text = string.Empty;
            this.dateRendVous.Text = string.Empty;
            this.txtDescClt.Text = string.Empty;
            this.txtSearche.Text = string.Empty;
            this.guna2DataGridView1.DataSource = null;
        }

        private void btnAddM_Click(object sender, EventArgs e)
        {
            if (DatabaseConnection.connection.State == System.Data.ConnectionState.Closed)
            {
                DatabaseConnection.connection.Open();
            }
            SqlCommand cmd = new SqlCommand("INSERT INTO detaille(idClt,idM,Qte) VALUES(@idclt,@idm,@qte)", DatabaseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idclt", this.txtIdClt.Text);
            cmd.Parameters.AddWithValue("@idm", int.Parse( this.guna2ComboBox1.SelectedValue.ToString()));
            cmd.Parameters.AddWithValue("@qte", this.txtQte.Text);
            cmd.ExecuteNonQuery();
            MessageBox.Show("le medicament est bien ajouter!");
            this.txtQte.Text = string.Empty;
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.guna2ComboBox1.SelectedValue is Int32)
                {
                    this.doctor.Currentpatient = new Patient();
                    this.doctor.Currentpatient.Cuuerntconsultation = new Consultation();
                    this.doctor.Currentpatient.Cuuerntconsultation.CurrentMedicament = new Medicament();
                    this.doctor.Currentpatient.Cuuerntconsultation.CurrentMedicament = new Medicament(int.Parse(this.guna2ComboBox1.SelectedValue.ToString()));
                }
                //var selectedCIN = this.guna2ComboBox1.SelectedValue?.ToString();
                //if (string.IsNullOrEmpty(selectedCIN))
                //{
                //    MessageBox.Show("Sélection non valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    return;
                //}

                //this.doctor.Currentpatient.Cuuerntconsultation.CurrentMedicament = new Medicament(int.Parse(selectedCIN));
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            //this.guna2ComboBox1.DataSource = this.doctor.Currentpatient.Cuuerntconsultation.chrgermedicament();
            //this.guna2ComboBox1.DisplayMember = "nom";
            //this.guna2ComboBox1.ValueMember = "idM";
        }

        int position = -1;
        string IdClt;
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = this.guna2DataGridView1.CurrentRow.Index;
            IdClt = this.guna2DataGridView1.Rows[position].Cells[0].Value.ToString();
            this.txtIdClt.Text = this.guna2DataGridView1.Rows[position].Cells[0].Value.ToString();
            this.CbCin.Text = this.guna2DataGridView1.Rows[position].Cells[1].Value.ToString();
            this.dateClt.Text = this.guna2DataGridView1.Rows[position].Cells[2].Value.ToString();
            this.txtDescClt.Text = this.guna2DataGridView1.Rows[position].Cells[3].Value.ToString();
            this.dateRendVous.Text = this.guna2DataGridView1.Rows[position].Cells[4].Value.ToString();
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

        private void parcourirConsultationToolStripMenuItem_Click(object sender, EventArgs e)
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
