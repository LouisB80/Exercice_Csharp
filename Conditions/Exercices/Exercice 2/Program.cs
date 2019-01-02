using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 0;

            Console.WriteLine("Renseigner votre age !");
            int.TryParse(Console.ReadLine(), out age);

            if (age < 18 && age > 0)
            {
                Console.WriteLine("Vous avez " + age + " ans, vous etes donc mineur !");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Vous avez " + age + " ans, vous etes donc majeur !");
            }
            else
            {
                Console.WriteLine("Erreur");
            }
            

            Console.ReadKey();
        }
    }
}
