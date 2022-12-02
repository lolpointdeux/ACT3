using ACT3;
using System;

namespace ACT3_Elephants
{
    class Program
    {
       
        static void Main(string[] args)
        {
            string choice = "";

           
            Class1[] Elephants = new  Class1[2];
            Elephants[0] = new  Class1("Zazou", 100);
            Elephants[1] = new  Class1("Titi", 120);
            Class1[] AutreElephants = new  Class1[7];
            AutreElephants[0] = new  Class1("1", 134);
            AutreElephants[1] = new  Class1("2", 96);
            AutreElephants[2] = new  Class1("3", 50);
            AutreElephants[3] = new  Class1("4", 78);
            AutreElephants[4] = new  Class1("5", 26);
            AutreElephants[5] = new  Class1("6", 10);
            AutreElephants[6] = new  Class1("7", 5);

            Console.WriteLine("Choisissez \n 1 pour afficher les info de zazou \n 2 pour afficher les info de titi \n 3 pour les échanger \n 4 pour vois le transfer d'un message de zazou à titi \n 5 pour reviser la notion de tableau et l'appliquer aux objets");
            choice = Console.ReadLine();

            Choix(choice, Elephants, AutreElephants);
            Console.ReadLine();
        }
        static void Choix(string choix, Class1[] Elephants, Class1[] AutreElephants)
        {
            string exist = "je suis ";
            switch (choix)
            {
                case "1":
                    exist += Elephants[0].AfficherElephant();
                    break;

                case "2":
                    exist += Elephants[1].AfficherElephant();
                    break;

                case "3":
                    Class1 cacheElephant = Elephants[0];
                    Elephants[0] = Elephants[1];
                    Elephants[1] = cacheElephant;
                    exist += Elephants[0].AfficherElephant();
                    exist += "\n";
                    exist += Elephants[1].AfficherElephant();
                    break;

                case "4":
                    Elephants[1].Message("Bonjour", Elephants[0]);
                    Elephants[0].LectureMessage("Bonjour", Elephants[1]);
                    exist = null;
                    break;

                case "5":
                    exist += VerifOreilles(AutreElephants).AfficherElephant();
                    break;
            }
            static Class1 VerifOreilles(Class1[] AutreElephants)
        {
            
            int IE = 0;
            uint LaPlusGrandOreilles = 0;
            for (int i = 0; i < AutreElephants.Length; i++)
            {
                if (LaPlusGrandOreilles < AutreElephants[i].AvoirOreilles())
                {
                    LaPlusGrandOreilles = AutreElephants[i].AvoirOreilles();
                    IE = i;
                }
            }

            return AutreElephants[IE];
        }
            Console.WriteLine(exist);



        }
    }
}