using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Personne
    {
        int id;
        string prenom;
        string nom;
        DateTime dateNaissance;
        string email;
        string password;
        string confirmPassword;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }
    }

}
