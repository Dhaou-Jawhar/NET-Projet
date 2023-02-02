using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        public DateTime BirthDate { get; set; }
        public int PasseportNumber { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int TelNumber { get; set; }

        List<Flight> Flights { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }

        public Passenger()
        {

        }

        public Passenger(DateTime birthDate, int passeportNumber, string emailAddress, string firstName, string lastName, int telNumber)
        {
            BirthDate = birthDate;
            PasseportNumber = passeportNumber;
            EmailAddress = emailAddress;
            FirstName = firstName;
            LastName = lastName;
            TelNumber = telNumber;
        }

        public bool CheckProfile(string nom, string prenom)
        {
            return FirstName == nom && LastName == prenom;
        }



        public bool CheckProfile(string nom, string prenom , string mail)
        {
            return FirstName == nom && LastName == prenom && EmailAddress == mail;
        }

        public bool CheckProfile2(string nom = "", string prenom = "", string email = "")
        {
            if (string.IsNullOrEmpty(prenom) && string.IsNullOrEmpty(nom) && string.IsNullOrEmpty(email))
            {
                return false;
            }

            if (!string.IsNullOrEmpty(prenom) && this.FirstName != nom)
            {
                return false;
            }

            if (!string.IsNullOrEmpty(nom) && this.LastName != prenom)
            {
                return false;
            }

            if (!string.IsNullOrEmpty(prenom) && this.EmailAddress != email)
            {
                return false;
            }

            return true;
        }
    }
}
