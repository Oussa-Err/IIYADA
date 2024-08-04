using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace gestionCabinie
{
    public class Doctor : User
    {
        public Doctor(string login, string password) : base(login, password)
        {


        }
        public override void afficherInterface()
        {
            new FormDoctor(this).Show();
        }
        public void ajouter(Consultation consultation)
        {
            //Patient patient = new Patient(Login);
            //patient.AjouterCLt(consultation);
            this.Currentpatient.AjouterCLt(consultation);
            ////SqlCommand cmd = new SqlCommand("insert into cansultations(idClt,CIN,date,descreption,date_rendevous)values(@idClt,@CIN,@date,@descreption,@date_rendevous)", DatabaseConnection.connection);
            ////cmd.CommandType = CommandType.Text;
            ////cmd.Parameters.AddWithValue("@idClt", consultation.IdClt);
            ////cmd.Parameters.AddWithValue("@CIN", consultation.Cin);
            ////cmd.Parameters.AddWithValue("@date", consultation.Date);
            ////cmd.Parameters.AddWithValue("@descreption", consultation.Descreption);
            ////cmd.Parameters.AddWithValue("@date_rendevous", consultation.DateRendevous);
            ////cmd.ExecuteNonQuery();
        }
        //public void ajouterm(Medicament medicament)
        //{
        //    this.Currentpatient.Cuuerntconsultation.ajouterM(medicament);

        //}
       
    }
}
