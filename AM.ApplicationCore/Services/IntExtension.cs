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
            public static int add(this int a , int b) // thi int a ( pour injecter dans la classe int )
            {
                    return a + b;
            }
        }

    //si on int + float 
    //public static string ( ou void ) add(this int a , float b, float c) 

}
