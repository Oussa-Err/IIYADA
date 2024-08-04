using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace gestionCabinie
{
    public class Consultation
    {
        private Int32 idClt;
        private string cin;
        private DateTime date;
        private string descreption;
        private DateTime dateRendevous;
        private DataTable medicaments = new DataTable();
        private Medicament currentMedicament;
        private SqlDataAdapter SqlDataAdapterMDc;


        public Consultation()
        {

        }


        public Consultation(int idClt, string cin, DateTime date, string descreption, DateTime dateRendevous)
        {
            this.idClt = idClt;
            this.cin = cin;
            this.date = date;
            this.descreption = descreption;
            this.dateRendevous = dateRendevous;
        }
        public Consultation(int idClt)
        {
            IdClt = idClt;

        }

        public int IdClt { get => idClt; set => idClt = value; }
        public DateTime Date { get => date; set => date = value; }
        public string Descreption { get => descreption; set => descreption = value; }
        public DateTime DateRendevous { get => dateRendevous; set => dateRendevous = value; }
        public DataTable Medicaments { get => medicaments; set => medicaments = value; }
        internal Medicament CurrentMedicament { get => currentMedicament; set => currentMedicament = value; }
        public SqlDataAdapter SqlDataAdapterMDc1 { get => SqlDataAdapterMDc; set => SqlDataAdapterMDc = value; }
        public string Cin
        {
            get => cin; set => cin = value;
        }
        public void ajouterM(Medicament medicament)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO medicaments(idM,nom)VALUES(@idM,@nom)", DatabaseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@idM", medicament.Id);
            cmd.Parameters.AddWithValue("@nom", medicament.Nom);
            cmd.ExecuteNonQuery();
        }
        public void modifierMd(Medicament medicament)
        {
            SqlCommand command = new SqlCommand("UPDATE medicaments SET nom=@nom where  idM=@idm ", DatabaseConnection.connection);
            command.CommandType = CommandType.Text;
            command.Parameters.AddWithValue("@idM", medicament.Id);
            command.Parameters.AddWithValue("@nom", medicament.Nom);
            command.ExecuteNonQuery();
        }
        public DataTable chrgermedicament()
        {
            SqlCommand cmd = new SqlCommand("SELECT * from medicaments ", DatabaseConnection.connection);
            this.SqlDataAdapterMDc = new SqlDataAdapter(cmd);
            this.medicaments.Clear();
            this.SqlDataAdapterMDc.Fill(this.medicaments);
            return this.medicaments;


        }
        public void saerchMD(string nom)
        {
            SqlCommand cmd = new SqlCommand("select * from medicaments where nom=@nom", DatabaseConnection.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@nom", nom);
            SqlDataReader rd = cmd.ExecuteReader();

            if (rd.Read())
                this.currentMedicament = new Medicament(rd.GetInt32(0), rd.GetString(1));
            rd.Close();
        }
    }



    }
