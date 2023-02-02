using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public enum PlaneType
    {
        Boing, Airbus
    }
    public class Plane
    {
        public double Capacity { get; set; }
        public DateTime ManualFactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType PlaneType { get; set; }

        List<Flight> Flights { get; set; }
        List<Passenger> Passes { get; set; }

        /*/*Créer un objet non initialisé de type Plane en utilisant le constructeur non paramétré de la
           classe, puis initialiser ses attributs à travers leurs propriétés.*/
        public Plane()
        {

        }
        public override string ToString()
        {
            return +Capacity+" "+ManualFactureDate+" "+PlaneType;
        }

        public Plane(PlaneType pt, int capacity, DateTime date)
        {
            this.Capacity = capacity;
            this.ManualFactureDate = date;
            this.PlaneType = pt;
        }



    }
}
