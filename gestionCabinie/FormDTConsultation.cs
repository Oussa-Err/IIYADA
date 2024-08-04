using gestionCabinie.Utils;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace gestionCabinie
{
    public partial class FormDTConsultation : Form
    {
        private Doctor Doctor;

        private DataTable consultations = new DataTable();
        private Consultation cuuerntconsultation;
        private SqlDataAdapter SqlDataAdapterClt;

        public DataTable Consultations { get => consultations; set => consultations = value; }
        public Consultation Cuuerntconsultation { get => cuuerntconsultation; set => cuuerntconsultation = value; }
        public SqlDataAdapter SqlDataAdapterClt1 { get => SqlDataAdapterClt; set => SqlDataAdapterClt = value; }

        public FormDTConsultation(Doctor doctor)
        {
            InitializeComponent();
            Doctor = doctor;
            FormBorderStyle = FormBorderStyle.Sizable;
        }

        private void FormDTConsultation_Load(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM cansultations", DatabaseConnection.connection);
            cmd.CommandType = CommandType.Text;
            this.SqlDataAdapterClt = new SqlDataAdapter(cmd);
            this.consultations.Clear();
            this.SqlDataAdapterClt.Fill(consultations);
            this.DTConsultation.DataSource = this.consultations;
            //try
            //{
            //}
            //catch (Exception ex)
            //{
            //    System.Windows.MessageBox.Show(ex.Message);
            //}
        }

        private void gérerConsultationToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            FormConsultation formConsultation = new FormConsultation(Doctor);
            FormPositionUtil.OpenNewForm(this, formConsultation);
            this.Close();
        }

        private void gérerMédicamentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMedicament formMidecament = new FormMedicament(Doctor);
            FormPositionUtil.OpenNewForm(this, formMidecament);
            this.Close();
        }

        private void parcourirConsultationToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FormDTConsultation formDTConsultation = new FormDTConsultation(Doctor);
            FormPositionUtil.OpenNewForm(this, formDTConsultation);
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
