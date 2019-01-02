
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rainy = true;

            if(rainy)
            {
                Console.WriteLine("Bonjours, il pleut aujourd'hui, vous devriez prendre votre parapluie !");
            }
            else
            {
                Console.WriteLine("Bonjour, il ne pleut pas aujourd'hui, bonne journee.");
            }
            
            Console.ReadKey();
        }
    }
}
