using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        [StringLength(7),Key]
        public string PassportNumber { get; set; }
        public FullName FullName { get; set; }

        [DataType(DataType.DateTime), DisplayName("Date pf birth")]
        public DateTime BirthDate { get; set; }

        [DataType(DataType.PhoneNumber)]
        public int TelNumber { get; set; }

        [EmailAddress]
        /*
         * [DataType(DataType.PhoneNumber)]
         *      ou
         * [PhoneNumber]
         */
        public string EmailAdress { get; set; }
        /*public int Id { get; set; }*/
        public ICollection<Flight> Flights { get; set; }

        #region Polymorphisme Par signature
        public bool checkProfile(string nom, string prenom)
        {
            return FullName.FirstName.Equals(nom) && FullName.LastName.Equals(prenom);
        }
        public bool checkProfile(string nom , string prenom ,string email)
        {
            return FullName.FirstName.Equals(nom) && FullName.LastName.Equals(prenom) && EmailAdress.Equals(email);
        }
        public virtual void passengerType()
        {
            Console.WriteLine("I m Passenger");
        }
        #endregion Polymorphisme Par signature
    }
}
