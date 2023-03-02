using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        [Display(Name = "Date of Birth"), DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [MaxLength(7) , Key]
        public int PassportNumber { get; set; }
        [DataType(DataType.EmailAddress)] //[EmailAddress]
        public string EmailAddress { get; set; }
        [StringLength(maximumLength:25 , MinimumLength =3 , ErrorMessage ="règle pas respectées")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [MinLength(7), MaxLength(7)] // (string) [RegularExpression]
        [RegularExpression("[0-9]{8}")] // {,8} de 0->8 / {8,} de 8->infini / {8,16} de 8->16
        public string TelNumber { get; set; }
        public ICollection<Flight> flights { get; set; }
        public override string ToString()
        {
            return FirstName + " " + LastName + " " + BirthDate + " " + PassportNumber + " " + EmailAddress + " " + TelNumber;
        }
        //10-a)

        //public bool checkProfil(string nom, string prenom) {

        //    return FirstName==nom && LastName==prenom;
        //}
        //b)

        //public bool checkProfil(string nom, string prenom,string email)
        //{

        //    return FirstName == nom && LastName == prenom && EmailAddress==email;
        //}

        //c)
        public bool checkProfil(string nom, string prenom, string email = null)
        {
            if (email == null)
            {
                return FirstName == nom && LastName == prenom;
            }
            return FirstName == nom && LastName == prenom && EmailAddress == email;
        }
        //11)
        public virtual void PassengerType()
        {
            Console.WriteLine("I am a passenger");
        }

    }

}
