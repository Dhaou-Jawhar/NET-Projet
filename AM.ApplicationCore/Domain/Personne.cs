﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Personne
    {

        /*constructeur sans parametre = ctor ( double tabulation) */
        public Personne()
        {
                
        }

        public bool login(string nom, string password) {

            //var result = nom == nom || password == password ? true : false;
            //return result;

            //----------------------[OU]---------------------------

            //if (nom==nom && password==password)
            //    return true;
            //else return false;

            return nom == nom && password == password;
        }

        public bool login(string nom, string password, string email) { 
        
            return nom == nom && password == password && email == email;
        }


        /*selectionner les proprités et ajouter un constructeur par la lompe jaune */
        public Personne(string nom, string prenom, DateTime dateNaissance, string email, string password, string confirmPassword)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.dateNaissance = dateNaissance;
            this.email = email;
            this.password = password;
            this.confirmPassword = confirmPassword;
        }

        public int Id
        {
            get;
            set;
        }
        /* prop + double Tabulation = public int MyProperty { get; set; } */

        public string nom { get; set; }
        public string prenom { get; set; }
        public DateTime dateNaissance { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string confirmPassword { get; set; }

        /*override to string */
        /* base = ( super dans java )  */
        public override string ToString()
        {
            return Id+ " "+ nom+ " "+ prenom+ " "+email;
        }

        public void GetMyType()
        {
            Console.WriteLine("je suis un Personne");
        }
    }

}
