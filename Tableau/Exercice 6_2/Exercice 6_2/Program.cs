using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_6_2
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
        static void Main(string[] args)
        {
            //Recuperer les infos
            String[] week = Enum.GetNames(typeof(week));

            foreach (String day in week)
            {
                Console.WriteLine(day);
            }
            
            Console.ReadKey();
        }
    }
}
