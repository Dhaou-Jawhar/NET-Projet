using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    /*heritage c#  ( conducteur herite from personne ) */
    public class Conducteur : Personne
    {
        public DateTime DatePermis { get; set; }
        public string TypePermis { get; set; }


        /*base ( de personne ) + les proprités de Conducteur */
        public override string ToString()
        {
            return base.ToString() + " "+DatePermis+" "+TypePermis;
        }

        public override void GetMyType() {
            Console.WriteLine("je suis un conducteur");
        }

    }
}
