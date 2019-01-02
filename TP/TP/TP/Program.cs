using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP
{
    class Program
    {
        static void Main(string[] args)
        {
            float imc = 0;
            float weight = 0, size = 0; ;

            Console.WriteLine("Bonjours, veuillez entrer votre taille.");
            float.TryParse(Console.ReadLine(), out size);
            Console.WriteLine("Votre poids.");
            float.TryParse(Console.ReadLine(),out weight);

            imc = (weight / (size*size));

            Console.WriteLine("Votre imc est de {0} " , imc);
            if (imc < 16.5)
            {
                Console.WriteLine("Dénutrition");
            }
            else if (imc >= 16.5 && imc < 18.5)
            {
                Console.WriteLine("Maigreur");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Corpulence normal");
            }
            else if (imc >=25 && imc < 30)
            {
                Console.WriteLine("Surpoids");
            }
            else if (imc >= 30 && imc < 35)
            {
                Console.WriteLine("Obésité modérée");
            }
            else if (imc >= 35 && imc < 40)
            {
                Console.WriteLine("Obésité sévère.");
            }
            else if (imc >= 40)
            {
                Console.WriteLine("Obésité massive ou morbide");
            }
            Console.ReadKey();
        }
    }
}