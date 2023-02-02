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

