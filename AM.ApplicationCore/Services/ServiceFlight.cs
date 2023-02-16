using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class ServiceFlight : IServiceFlight
    {

        //initialiser vide = new List<Fight>()
        public List<Flight> Flights { get; set; } = new List<Flight>();

        // 6)
        public List<DateTime> GetFlightDates(string destination)
        {
            List<DateTime> z = new List<DateTime>();
            //for(int i = 0; i < Flights.Count; i++)
            //{
            //    if (Flights[i].Destination==destination)
            //        dates.Add(Flights[i].FlightDate);
            //}
            //return dates;

            // 7)
            //List<DateTime> dates = new List<DateTime>();
            //foreach (var flight in Flights)
            //{
            //    if (flight.Destination == destination)
            //    {
            //        dates.Add(flight.FlightDate);
            //    }

            //}

            //Syntaxe de  Requete

            //var query = from flight in Flights
            //         where flight.Destination == destination
            //         select flight.FlightDate;
            //return query.ToList();   // car query = Enumerable et la methode return IList ( ToList ) Convertion + Execution du requet

            //Syntaxe de methode

            var query = Flights
                .Where(Flights => Flights.Destination == destination)
                .Select(Flights => Flights.FlightDate) .ToList();

            return query;
        }

        // 8)
        public List<Flight> GetFlights(string filterValue, Func<Flight, String, Boolean> condition)
        {
            List<Flight> flights = new List<Flight>();

            foreach (var flight in Flights)
            {
                if (condition(flight, filterValue))
                {
                    flights.Add(flight);
                    Console.WriteLine(flight);
                }
            }

            //if (filterType.Equals("Destination"))
            //{

            //    foreach (var flight in Flights)
            //    {
            //        if (flight.Destination.Equals(filterValue))
            //        {
            //            flights.Add(flight);
            //            Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.PlaneType, flight.EstimateDuration, flight.passengers);

            //        }
            //    }

            //}
            //if (filterType.Equals("PlaneType"))
            //{

            //    foreach (var flight in Flights)
            //    {
            //        if (flight.plane.PlaneType.Equals(filterValue))
            //        {
            //            flights.Add(flight);
            //            Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.PlaneType, flight.EstimateDuration, flight.passengers);

            //        }
            //    }

            //}
            //if (filterType.Equals("PlaneType"))
            //{

            //    foreach (var flight in Flights)
            //    {
            //        if (flight.plane.PlaneType.Equals(filterValue))
            //        {
            //            flights.Add(flight);
            //            Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.PlaneType, flight.EstimateDuration, flight.passengers);

            //        }
            //    }

            //}
            //if (filterType.Equals("FlightDate"))
            //{

            //    foreach (var flight in Flights)
            //    {
            //        if (flight.FlightDate.Equals(filterValue))
            //        {
            //            flights.Add(flight);
            //            Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.PlaneType, flight.EstimateDuration, flight.passengers);
            //        }
            //    }

            //}
            //if (filterType.Equals("EffectiveArrival"))
            //{

            //    foreach (var flight in Flights)
            //    {
            //        if (flight.EffectiveArrival.Equals(filterValue))
            //        {
            //            flights.Add(flight);
            //            Console.WriteLine("FlightDate: {0} Destination: {1}  EffectiveArrival: {2}  Plane:{3} EstimateDuration: {4} Passengers: {5}", flight.FlightDate, flight.Destination, flight.EffectiveArrival, flight.plane.PlaneType, flight.EstimateDuration, flight.passengers);

            //        }
            //    }

            //}
            return flights;
        }

        // 9 )
        void ShowFlightDetails(Plane plane)
        {
            var query = Flights
                .Where(f => f.plane.PlaneId == plane.PlaneId)
                .Select(f => new { f.Destination, f.FlightDate });
        foreach (var item in query)
            {
                Console.WriteLine(item);
            }
        }
        //Ex 11

        int ProgrammedFlightNumber(DateTime startDate)
        {
            var query = Flights
                .Count(f => f.FlightDate > startDate && (f.FlightDate - startDate).TotalDays < 7);
            return query;
        }

        //Ex 12
        Double DurationAverage(string destination)
        {
            var query = Flights
                .Where(f => f.Destination.Equals(destination))
                .Average(f => f.EstimateDuration);
            return query;
        }

        //Ex 13
        List<Flight> OrderedDurationFlights()
        {
            //var query = Flights
            //    .OrderByDescending(f => f.EstimateDuration).ToList();

            //Syntax de requet
            var query = from f in Flights
                        orderby f.EstimateDuration descending
                        select (f);

            return query.ToList();
        }

        //Ex 14
        List<Traveller> SeniorTravellers(Flight flight)
        {
            var query = flight.passengers.OfType<Traveller>()  
                    //.Where(p => p is Traveller)   // bech yraja3li liste passenger , donc nbadeloha list traveller
                    .OrderBy(p => p.BirthDate).Take(3).ToList();

            List<Passenger> p = new List<Passenger>(query);   // cast implicite
            return query;
        }
    }
}
