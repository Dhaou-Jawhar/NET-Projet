using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    public interface IServiceFlight
    {
        public List<DateTime> GetFlightDates(string destination);

        void ShowFlightDetails(Plane plane);
        int ProgrammedFlightNumber(DateTime startDate);
        Double DurationAverage(string destination);
        List<Flight> OrderedDurationFlights();
        List<Traveller> SeniorTravellers(Flight flight);
       public void GetFlights(string filterType, string filterValue);
    }
}
