using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{

    //TP4 - Q11
    [Owned]
    public class FullName
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }


}
