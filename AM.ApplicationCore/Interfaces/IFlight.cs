﻿using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;

using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Interfaces
{
    internal interface IFlight
    {
        IList<DateTime> GetFlightDates(string destination);
        public void ShowFlightDetails(Plane plane);
        public int ProgrammedFlightNumber(DateTime startDate);
        public double DurationAverage(string destination);
        public IList<Flight> OrderedDurationFlights();
        public IEnumerable<Traveller> SeniorTravellers(Flight flight);
        public IEnumerable<IGrouping<string, Flight>> DestinationGroupedFlights();
    }
} 
