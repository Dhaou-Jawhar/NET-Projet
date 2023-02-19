using AM.ApplicationCore.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
    public static class PassengerExtension
    {
        public static string UpperFullName(this Passenger passenger)
        {
            if (string.IsNullOrEmpty(passenger.FirstName))
            {
                throw new ArgumentException("not null");
            }

            string[] names = passenger.FirstName.Split(' ');

            for (int i = 0; i < names.Length; i++)
            {
                names[i] = char.ToUpper(names[i][0]) + names[i].Substring(1);
            }

            return string.Join(' ', names);
        }
    }
}
}
