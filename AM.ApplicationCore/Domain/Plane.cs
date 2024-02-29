using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Plane
    {
        [Range(1,int.MaxValue,ErrorMessage ="La Capicity doit etre positive")]
        public int Capactity { get; set; }
        public DateTime ManufactureDate { get; set; }
        public int PlaneId { get; set; }
        public PlaneType Planetype { get; set; }
        public ICollection<Flight> Flights { get; set;}
        public string AirlineLogo { get; set; }

    }
}
