using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexe;
            int age = 0;
            //Renseigner le sexe.
            Console.WriteLine("Bonjour, quel est votre sexe ?");
            sexe = Console.ReadLine();

            //Renseigner l'age.
            Console.WriteLine("Quel age avez-vous ?");
            int.TryParse(Console.ReadLine(),out age);

            //Si la personne est un homme ou une femme et selon son age.
            if (sexe == "homme" && age >= 18)
            {
                Console.WriteLine("Vous êtes un homme et vous êtes majeur.");
            }
            else if (sexe == "homme" && age <= 17 && age > 0)
            {
                Console.WriteLine("Vous êtes un homme et vous êtes mineur.");
            }
            else if (sexe == "femme" && age >=18)
            {
                Console.WriteLine("Vous êtes une femme et vous êtes majeure.");
            }
            else if (sexe == "femme" && age <= 17 && age > 0)
            {
                Console.WriteLine("Vous êtes une femme et vous êtes mineure.");
            } 
            else
            {
                Console.WriteLine("erreur, fermeture du programme");
            }
        }
    }
}