using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_5_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            for (int number = 2; number < 7; number++)
            {
                numbers.Add(number);
            }
            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            // Ajouter
            numbers.Insert(0, 1);
            numbers.Add(7);
                        
            Console.WriteLine("\n");

            foreach (int i in numbers)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
