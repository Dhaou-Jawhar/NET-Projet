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
    }
}
