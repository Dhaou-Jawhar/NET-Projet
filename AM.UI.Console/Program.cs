//// See https://aka.ms/new-console-template for more information
////declaration variable 
//string ch;
////type: string, int, char, double, float, bool,DateTime, long, ....

//for (int i = 0; i < 2; i++)
//{
//    ch = Console.ReadLine();

//    Console.WriteLine("Bonjour " + ch);



//    int chiffreValue = 0;

//   // do
//    //
//        try
//        {
//            string chiffre = Console.ReadLine();
//            chiffreValue = int.Parse(chiffre);
//        if (chiffreValue > 15 && chiffreValue <= 18)
//        { Console.WriteLine("Ados"); }
//        else if (chiffreValue > 18)
//        { Console.WriteLine("Adulte"); }

//    }
//        catch
//        {
//            Console.WriteLine("Erreur au niveau de conversion du chiffre");
//        }
//    //} while (chiffreValue == 0);

//    Console.WriteLine("Votre nombre est " + (chiffreValue + 1));

//}

using AM.ApplicationCore.Domain;

Personne p = new Personne();
p.Id = 11;
p.nom = "Dhaou";
p.prenom = "Jawhar";
p.email = "dhaou.jawhar@esprit.tn";
p.dateNaissance= new DateTime(2000, 12, 25);
p.password = "1234";
p.confirmPassword = "1234";

Console.WriteLine(p);

/*constructeur avec parametre*/
Personne p1 = new Personne("nom", "prenom",DateTime.Now,"email","password","confirmPassword" );
Console.WriteLine(p1);


/*Initialisateur d'objet*/
Personne p2 = new Personne()
{
    email="email",
    nom="Dhaou",
    prenom="Jawhar",
    confirmPassword="1234",
    dateNaissance=DateTime.Now,
    password="1234"
};

//Conducteur c = new Conducteur();
//p.GetMyType();
//c.GetMyType();

/* c. et p. ( prend le mm methode dans personne ) */
/*pour fixer le problème ( override dans la methode de la classe fils et vitual dans la methode de classe mere ) */
/*redifinition des methodes */
Personne c = new Conducteur();
p.GetMyType();
c.GetMyType();


/*Créer un objet non initialisé de type Plane en utilisant le constructeur non paramétré de la
classe, puis initialiser ses attributs à travers leurs propriétés.*/

Plane pl = new Plane();
{
    pl.Capacity = 123;
    pl.ManualFactureDate= DateTime.Now;
    pl.PlaneId= 3;
    pl.PlaneType = PlaneType.Boing ;
}
Console.WriteLine("-------[Question 7]-------");
Console.WriteLine(pl);

/*Quest 8*/
//Plane avion = new Plane(PlaneType.Airbus,300,DateTime.Now);
//Console.WriteLine(avion);

Plane avion2 = new Plane()
{
    Capacity = 350,
    ManualFactureDate = DateTime.Now,
    PlaneId = 4,
    PlaneType = PlaneType.Airbus
};
Console.WriteLine("-------[Question 8 et 9]-------");
Console.WriteLine(avion2);




/*III Le Polymorphisme*/
/* 10 ) a- */
Passenger pass = new Passenger()
{
    BirthDate = DateTime.Now,
    PasseportNumber = 95332,
    EmailAddress = "test@esprit.tn",
    FirstName = "Dhaou",
    LastName = "Jawhar",
    TelNumber = 24232423
};

Console.WriteLine("-------[Question 10 : a ) ]-------");
bool result = pass.CheckProfile2("Dhaou", "Jawhar");

if (result)
{
    Console.WriteLine("Profile matches");
}
else
{
    Console.WriteLine("Profile does not match");
}

/* 10 ) b- */

/*Juste True or false affichage */
Console.WriteLine("-------[Question 10 : b ) ]-------");
Console.WriteLine(pass.CheckProfile2("Dhaou", "Jawhar", "test@esprit.tn"));




/* 10 ) c- */
Console.WriteLine("-------[Question 10 : c ) ]-------");
bool result1 = pass.CheckProfile2("Dhaou", "Jawhar");

if (result1)
{
    Console.WriteLine("Profile matches( 2 param )");
}
else
{
    Console.WriteLine("Profile does not match( 2 param )");
}

bool result2 = pass.CheckProfile2("Dhaou", "Jawhar", "test@esprit.tn");

if (result2)
{
    Console.WriteLine("Profile matches (3 parameters)");
}
else
{
    Console.WriteLine("Profile does not match (3 parameters)");
}


/*11. Polymorphysme par héritage*/

/* a ) */
Console.WriteLine("-------[Question 11 : a & b & c ) ]-------");
Passenger psst = new Passenger();
psst.PassengerType();

/* b )  et c ) */
Staff st = new Staff();
Traveller tr = new Traveller();
st.PassengerType();
tr.PassengerType();









