using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_5
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection fujita = new NewValueCollection();
            fujita.Add("F0", "Degats legers");
            fujita.Add("F1", "Degats modéres");
            fujita.Add("F2", "Degats importants");
            fujita.Add("F3", "Degats considérables");
            fujita.Add("F4", "Degats dévastateurs");
            fujita.Add("F5", "Degats incroyables");

            Console.WriteLine("Entrer un type de tornade");
            String type = Console.ReadLine();
            switch (type)
            {
                case "F0":
                    Console.WriteLine(fujita["F0"]);
                    break;
                case "F1":
                    Console.WriteLine(fujita["F1"]);
                    break;
                case "F2":
                    Console.WriteLine(fujita["F2"]);
                    break;
                case "F3":
                    Console.WriteLine(fujita["F3"]);
                    break;
                case "F4":
                    Console.WriteLine(fujita["F4"]);
                    break;
                case "F5":
                    Console.WriteLine(fujita["F5"]);
                    break;
                default:
                    Console.WriteLine("Erreur");
                    break;
            }
            Console.ReadKey();
        }
    }
}