using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace gestionCabinie
{
    public class Patient
    {
        private string cin;
        private string nom;
        private string prenom;
        private string adress;
        private string tel;
        private DataTable consultations = new DataTable();
        private Consultation cuuerntconsultation;
        private SqlDataAdapter SqlDataAdapterClt;
        public Patient()
        { 
        }

        public Patient(string cin)
        {
            this.cin = cin;
        }

        public Patient(string cin, string nom, string prenom, string adress, string tel)
        {
            this.cin = cin;
            this.nom = nom;
            this.prenom = prenom;
            this.adress = adress;
            this.tel = tel;
        }
        public string Cin { get => cin; set => cin = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adress { get => adress; set => adress = value; }
        public string Tel { get => tel; set => tel = value; }
        public DataTable Consultations { get => consultations; set => consultations = value; }
        public Consultation Cuuerntconsultation { get => cuuerntconsultation; set => cuuerntconsultation = value; }
        public SqlDataAdapter SqlDataAdapterClt1 { get => SqlDataAdapterClt; set => SqlDataAdapterClt = value; }

        public void ajouterPatient(Patient patient)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO patients(CIN,nom,prenom,adress,tel)VALUES(@CIN,@nom,@prenom,@adress,@tel)", DatabaseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@CIN", patient.Cin);
            cmd.Parameters.AddWithValue("@nom", patient.Nom);
            cmd.Parameters.AddWithValue("@prenom", patient.Prenom);
            cmd.Parameters.AddWithValue("@adress", patient.Adress);
            cmd.Parameters.AddWithValue("@tel", patient.Tel);
            cmd.ExecuteNonQuery();
        }
        public void modifierPt(Patient patient)
        {
            SqlCommand cmd = new SqlCommand("update patients set nom=@nom,prenom=@prenom,adress=@adress,tel=@tel  where CIN=@cin ", DatabaseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@cin", this.Cin);
            cmd.Parameters.AddWithValue("@nom", this.Nom);
            cmd.Parameters.AddWithValue("@prenom", this.Prenom);
            cmd.Parameters.AddWithValue("@adress", this.Adress);
            cmd.Parameters.AddWithValue("@tel", this.Tel);
            cmd.ExecuteNonQuery();


        }
        public void modifierCLt(Consultation consultation)
        {
            SqlCommand sqlCommand = new SqlCommand("update cansultations set CIN=@cin, date=@date ,descreption=@descreption,date_rendevous=@date_rendevous where idClt=@idclt ", DatabaseConnection.connection);
            sqlCommand.CommandType = CommandType.Text;
            sqlCommand.Parameters.AddWithValue("@idclt",consultation.IdClt);
            sqlCommand.Parameters.AddWithValue("@cin", this.cin);
            sqlCommand.Parameters.AddWithValue("@date",consultation.Date);
            sqlCommand.Parameters.AddWithValue("@descreption", consultation.Descreption);
            sqlCommand.Parameters.AddWithValue("@date_rendevous",consultation.DateRendevous);
            sqlCommand.ExecuteNonQuery();

        }
        public void AjouterCLt(Consultation consultation)
        {
            if (DatabaseConnection.connection.State == System.Data.ConnectionState.Closed)
            {
                DatabaseConnection.connection.Open();
            }
            SqlCommand cmd = new SqlCommand("insert into cansultations(idClt,CIN,date,descreption,date_rendevous)values(@idClt,@CIN,@date,@descreption,@date_rendevous)", DatabaseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idClt", consultation.IdClt);
            cmd.Parameters.AddWithValue("@CIN", this.Cin);
            cmd.Parameters.AddWithValue("@date", consultation.Date);
            cmd.Parameters.AddWithValue("@descreption", consultation.Descreption);
            cmd.Parameters.AddWithValue("@date_rendevous", consultation.DateRendevous);
            cmd.ExecuteNonQuery();
           


        }
        public void suppeimeCLTt(int idclt)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM  cansultations WHERE Idclt=@idclt",DatabaseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idclt",idclt);
            cmd.ExecuteNonQuery();
        }
        public DataTable getDT(string cmdText)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmdText,DatabaseConnection.connection);
            da.Fill(dt);
            return dt;
        }
        public void searchClt(string cin)
        {
            consultations = getDT("select * from cansultations where CIN='"+cin+"'");
        }
        public void searchCltID(int idclt)
        {
            SqlCommand cmd = new SqlCommand("select * from cansultations where idClt=@idclt", DatabaseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idclt", idclt);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
                this.Cuuerntconsultation = new Consultation(rd.GetInt32(0), rd.GetString(1), rd.GetDateTime(2), rd.GetString(3), rd.GetDateTime(4));
            rd.Close();


        }
        public DataTable chargerConsultation()
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM cansultations", DatabaseConnection.connection);
            cmd.CommandType = CommandType.Text;
            this.SqlDataAdapterClt = new SqlDataAdapter(cmd);
            this.consultations.Clear();
            this.SqlDataAdapterClt.Fill(consultations);
            return this.consultations;
        }
    }
}
