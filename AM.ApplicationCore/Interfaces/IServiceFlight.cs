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
       public void GetFlights(string filterType, string filterValue);
    }
}
