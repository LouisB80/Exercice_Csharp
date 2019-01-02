using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int random = rand.Next(51);
            int choice = 0;

            Console.WriteLine("Devinez un nombre ");
            int.TryParse(Console.ReadLine(), out choice);


            while (choice != random )
            {
                Console.WriteLine("Erreur, essaye encore");
                int.TryParse(Console.ReadLine(), out choice);
            }

            Console.WriteLine("Felicitation");
            Console.ReadKey();

        }
    }
}
