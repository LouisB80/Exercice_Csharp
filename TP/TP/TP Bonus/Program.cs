using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Bonus
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int random = rand.Next(51);
            int choice = 0, compt=0, maxcompt=0;

            Console.WriteLine("Definir un nombre de coup maximum pour cette partie !");
            int.TryParse(Console.ReadLine(), out maxcompt);
            
            while (compt < maxcompt)
            {
                Console.WriteLine("\nDevinez un nombre ");
                int.TryParse(Console.ReadLine(), out choice);
                compt++;

                if (choice != random && compt<maxcompt)
                {
                    Console.WriteLine("Erreur, essaye encore");
                }
                else if(choice == random)
                {
                    Console.WriteLine("Félicitation vous avez gagné en {0} coups !!!  ", compt);
                    compt = maxcompt;
                }
                else
                {
                    Console.WriteLine("Vous avez perdu, le nombre mystère été {0}", random);
                }
            }            
            Console.ReadKey();
        }
    }
}