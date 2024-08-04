using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionCabinie
{
    public class Medicament
    {
        private int id;
        private string nom;

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }

        public Medicament() 
        {
        }
        public Medicament(int id, string nom)
        {
            this.Id = id;
            this.Nom = nom;
        }
        public Medicament(int id)
        {
            this.Id = id;

        }
        //public void ajouterM(Medicament medicament)
        //{
        //    SqlCommand cmd = new SqlCommand("INSERT INTO medicaments(idM,nom)VALUES(@idM,@nom)", DatabaseConnection.connection);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.AddWithValue("@idM", medicament.Id);
        //    cmd.Parameters.AddWithValue("@nom", medicament.Nom);
        //    cmd.ExecuteNonQuery();
        //}

    }
}
