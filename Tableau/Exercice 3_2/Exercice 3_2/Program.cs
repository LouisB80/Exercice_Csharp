using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_3_2
{
    class Program
    {
        static void Main(String[] args)
        {
            String[] week = new String[] { "lundi", "mardi", "mercredi", "jeudi", "jeudi", "samedi", "dimanche" };

            foreach(String day in week)
            {
                Console.WriteLine(day);
            }

            Console.WriteLine("\n");
            // IndexOf : Retrouver l'indice d'un element dans un tableau, renvoi -1 si inexistant
            int i = Array.IndexOf(week,"jeudi");
            week[i+1] = "vendredi";

            foreach (String day in week)
            {
                Console.WriteLine(day);
            }
            Console.ReadKey();
        }
    }
}
