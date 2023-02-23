using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Services
{
        //V Les méthodes d’extension ( il faut créer des methodes static ) 
        public static class IntExtension
        {
            public static int add(this int a , int b)
            {
                    return a + b;
            }
        }
    
}
