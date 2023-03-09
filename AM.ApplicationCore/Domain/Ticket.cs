using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Ticket
    {
        public bool VIP { get; set; }
        public double Prix { get; set; }
        public string Siege { get; set; }
        public Passenger Passenger { get; set; }
        public Flight Flight { get; set; }
        public int FlightFK { get; set; }
        public int PassengerPK { get; set; }
    }
}
