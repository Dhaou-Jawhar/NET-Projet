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

Console.WriteLine(avion2);


