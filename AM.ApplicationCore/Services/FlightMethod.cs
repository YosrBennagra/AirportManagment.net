using AM.ApplicationCore.Domain;
using AM.ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public class FlightMethod : IFlight
    {
        IList<Flight>Flights= new List<Flight>();

        public IEnumerable<IGrouping<string,Flight>> DestinationGroupedFlights()
        {
            var Lambda = Flights.GroupBy(f => f.Destination);
            return Lambda;
        }

        public double DurationAverage(string destination)
        {
            var query = from f in Flights
                        where f.Destination == destination
                        select f.EstimatedDuration;
            return query.Average();
        }

        public IList<DateTime> GetFlightDates(string destination)
        {
            /*IList<DateTime> flights = new List<DateTime>();
            foreach (var item in Flights)
            {
                if(item.Destination == destination)
                {
                    flights.Add(item.FlightDate);
                }
                
            }*/
            #region LINQ
            var query = from item in Flights
                        where item.Destination == destination
                        select item.FlightDate;
            return query.ToList();
            #endregion LINQ
            /*return flights;*/

        }

        public IList<Flight> OrderedDurationFlights()
        {
            var query = from f in Flights
                        orderby f.EstimatedDuration
                        select f;
            return query.ToList();
        }

        public int ProgrammedFlightNumber(DateTime startDate)
        {
            #region LINQ
            /*var query = from f in Flights
                        where f.FlightDate >= startDate && f.FlightDate <= startDate.AddDays(7)
                        select f;
            return query.Count();*/
            #endregion LINQ
            #region Lambda
            var Lambda = Flights.Count(f => f.FlightDate >= startDate && f.FlightDate <= startDate.AddDays(7));
            return Lambda;
            #endregion Lambda
        }

        public IEnumerable<Traveller> SeniorTravellers(Flight flight)
        {
            var query = from p in flight.Passengers.OfType<Traveller>() 
                        orderby p.BirthDate
                        select p;
            return query.Take(3);
        }

        public void ShowFlightDetails(Domain.Plane plane)
        {
            var query = from f in Flights
                        where f.Plane.Equals(plane)
                        select new { f.Destination, f.FlightDate };
            foreach (var item in query)
            {
                Console.WriteLine("Destination: "+item.Destination+" FlightDate: "+item.FlightDate);
            }
        }

    }
}
