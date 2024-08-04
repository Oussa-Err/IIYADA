using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace gestionCabinie
{
    public class Secretaire:User
    {
        public Secretaire(string login,string password):base(login,password)
        { 
        
        
        
        }
        public override void afficherInterface()
        {
            new FormPatient(this).Show();
        }
        public void Ajouter(Patient patient)
        {
            patient.ajouterPatient(patient);
        }
    }
}
