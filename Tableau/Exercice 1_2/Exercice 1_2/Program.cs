using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] week = new String[] { "lundi", "mardi", "mercredi", "jeudi", "vendredi", "samedi", "dimanche" };

            foreach(String day in week)
            {
                Console.WriteLine(day);
            }

            Console.ReadKey();
        }
    }
}