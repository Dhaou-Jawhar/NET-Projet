using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Personne
    {
        public int Id
        {
            get;
            set;
        }
        /* prop + double Tabulation = public int MyProperty { get; set; } */

        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime dateNaissance { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }

        /*override to string */
        /* base = ( super dans java )  */
        public override string ToString()
        {
            return Id+ " "+ nom+ " "+ prenom+ " "+email;
        }
    }

}
