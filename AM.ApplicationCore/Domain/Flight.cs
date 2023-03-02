using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public string Destination { get; set; }
        public string Deparature { get; set; }
        public DateTime FlightDate { get; set; }
        public int FlightId { get; set; }
        public DateTime EffectiveArrival { get; set; }
        public float EstimateDuration { get; set; }
        [ForeignKey("plane")]
        public int ? PlaneFK { get; set; }  // ? pour le changer => nullable ( OnDelete(DeleteBehavior.SetNull/.Cascade/.Client SetNull ) 
        public Plane ? plane { get; set; } // ? pour le changer => nullable
        public ICollection<Passenger> passengers { get; set; }

        public override string ToString()
        {
            return FlightId + " " + Destination + " " + Deparature + " " + FlightDate + " " + EffectiveArrival + " " + EstimateDuration;
        }

    }
}
