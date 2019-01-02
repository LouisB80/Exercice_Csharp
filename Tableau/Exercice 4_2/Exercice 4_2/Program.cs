using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] shopping = new string[] { "Carrottes", "Oignons", "Pomme de terre", "Salade", "Tomate" };

            foreach(String prod in shopping)  
            {
                Console.WriteLine(prod);
            }

            Console.ReadKey();
        }
    }
}
