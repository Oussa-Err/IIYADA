using System;
using System.Data;
using System.Data.SqlClient;

namespace gestionCabinie
{
    public class User
    {
        private SqlConnection connection = DatabaseConnection.connection;
        private string login;
        private string password;
        private string type;
        private DataTable dtPatients = new DataTable();
        private SqlDataAdapter adapterPatient;
        private Patient currentpatient;

        public User(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public User(string login, string password, string type)
        {
            this.login = login;
            this.password = password;
            this.type = type;
        }

        public SqlConnection Connection { get => connection; set => connection = value; }
        public string Login { get => login; set => login = value; }
        public string Password { get => password; set => password = value; }
        public string Type { get => type; set => type = value; }


        public DataTable DtPatients { get => dtPatients; set => dtPatients = value; }
        public SqlDataAdapter AdapterPatient { get => adapterPatient; set => adapterPatient = value; }
        public Patient Currentpatient { get => currentpatient; set => currentpatient = value; }

        public override string ToString()
        {
            return this.login + '\t' + this.password + '\t' + this.type;
        }
        public void authantifier()
        {
            if (this.connection.State==System.Data.ConnectionState.Closed)
            {
                this.connection.Open();
            }
            //connection.Open();
            SqlCommand cmd = new SqlCommand("select * from users where @login=login and @password=password ", this.Connection);
            {
                cmd.Parameters.AddWithValue("@login", this.Login);
                cmd.Parameters.AddWithValue("@password", this.Password);
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    string type = reader.GetString(0);
                    User u = null;
                    switch (type)
                    {
                        case "doctor":
                            reader.Close();
                            u = new Doctor(this.Login, this.Password);
                            u.afficherInterface();

                            break;
                        case "secretaire":
                            reader.Close();
                            u = new Secretaire(this.Login, this.Password);
                            u.afficherInterface();
                            break;
                    }
                    //if (u != null)
                    //{
                    //    u.afficherInterface();
                    //}


                }
                else
                {
                    connection.Close();
                    throw new Exception("Login ou passeord incorrect !");
                }
                //reader.Close();
            }

            //using (var reader = db.ExecReader(cmd))
            //{
            //    if (reader.HasRows)
            //    {
            //        reader.Read();
            //        string type = reader.GetString(0);
            //    }
            //    User u = null;
            //    switch (type)
            //    {
            //        case "doctor":
            //            u = new Doctor(this.Login, this.Password);
            //            break;
            //        case "secretaire":
            //            u = new Secretaire(this.Login, this.Password);
            //            break;
            //    }
            //    if (u != null)
            //    {
            //        u.afficherInterface();
            //    }
            //    reader.Close();
            //}
        }

        public virtual void afficherInterface()
        {
        }

        public DataTable chargerPatient()
        {
            SqlCommand cmd = new SqlCommand("SELECT * from patients", this.connection);
            this.adapterPatient = new SqlDataAdapter(cmd);
            this.dtPatients.Clear();
            this.adapterPatient.Fill(this.dtPatients);
            return this.dtPatients;
        }

        public void suppeimerPt(string cin)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM patients WHERE CIN=@cin", this.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@cin", cin);
            cmd.ExecuteNonQuery();
        }

        public void searchPt(string cin)
        {
            SqlCommand cmd = new SqlCommand("select * from patients where CIN=@cin", this.connection);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@cin", cin);
            SqlDataReader reader = cmd.ExecuteReader();

            if (reader.Read())
                this.currentpatient = new Patient(reader.GetString(0), reader.GetString(1),
                    reader.GetString(2), reader.GetString(3), reader.GetString(4));
            reader.Close();
        }
    }
}
