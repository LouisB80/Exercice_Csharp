using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_8_2
{
    class Program
    {
        enum Week 
        {
            Monday=1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public static void Main(string[] args)
        {
            //Recuperer les infos d'enum
            foreach(string day in Enum.GetNames(typeof(Week)))
            {
                Console.WriteLine(day);
            }
            
            //Afficher le changement de valeur
            Console.WriteLine("\n la valeur Lundi est " + Enum.GetName(typeof(Week),1));

            //Afficher la quatrieme valeur de week
            Console.WriteLine("\n La quatrieme valeur de l'enumeration est : " + Enum.GetName(typeof(Week), 4));
            
            Console.ReadKey();
        }
    }
}