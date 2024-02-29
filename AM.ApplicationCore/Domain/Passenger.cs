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

        [MinLength(3, ErrorMessage ="Min Length 3"),MaxLength(25, ErrorMessage ="Max Length 25")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

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
            return FirstName.Equals(nom) && LastName.Equals(prenom);
        }
        public bool checkProfile(string nom , string prenom ,string email)
        {
            return FirstName.Equals(nom) && LastName.Equals(prenom) && EmailAdress.Equals(email);
        }
        public virtual void passengerType()
        {
            Console.WriteLine("I m Passenger");
        }
        #endregion Polymorphisme Par signature
    }
}
