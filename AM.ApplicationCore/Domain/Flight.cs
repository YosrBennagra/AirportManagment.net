using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Flight
    {
        public Flight(int flightId, DateTime flightDate, int estimatedDuration)
        {
            FlightId = flightId;
            FlightDate = flightDate;
            EstimatedDuration = estimatedDuration;
        }
        public Flight()
        {
        }
        public int FlightId { get; set; }
        public DateTime FlightDate { get; set; }
        public int EstimatedDuration { get; set; }
        public DateTime EffectiveArriaval { get; set; }
        public string Departure { get; set; }
        public string Destination { get; set; }
        public Plane Plane { get; set; }
           public ICollection<Passenger> Passengers { get; set;}


        #region prop
        /*        public int MyProperty { get; set; }*/
        #endregion
        #region propfull
        /*private int myVar;

        public int MyProperty
        {
            get { return myVar; }
            set { myVar = value; }
        }*/
        #endregion
    }
}
