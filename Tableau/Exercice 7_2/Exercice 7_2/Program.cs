using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;



namespace Exercice_7_2
{
    class Program
    {
        enum week
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public static void Main(string[] args)
        {
            //Afficher le contenu de l'enumeration
            foreach(string day in Enum.GetNames(typeof(week)))
            {
                Console.WriteLine(day);
            }

            //Afficher une valeur de l'enumeration
            Console.WriteLine("La quatrieme valeur de l'enumeration est : " + Enum.GetName(typeof(week), 4));
            Console.ReadKey();
        }
    }
}
