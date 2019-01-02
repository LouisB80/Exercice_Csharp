using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_6
{
    class Program
    {
        static void Main(string[] args)
        {
            NameValueCollection fujita = new NewValueCollection();
            fujita.Add("Janvier", "Hiver");
            fujita.Add("Fevrier", "Hiver");
            fujita.Add("Mars", "Printemps");
            fujita.Add("Avril", "Printemps");
            fujita.Add("Mai", "Printemps");
            fujita.Add("Juin", "Ete");
            fujita.Add("Juillet", "Ete");
            fujita.Add("Aout", "Ete");
            fujita.Add("Septembre", "Automne");
            fujita.Add("Octobre", "Automne");
            fujita.Add("Novembre", "Automne");
            fujita.Add("Decembre", "Hiver");

            Console.WriteLine("Entrer un type de tornade");
            String type = Console.ReadLine();

            switch (type)
            {
                case "Janvier":
                    Console.WriteLine(fujita["Janvier"]);
                    break;
                case "Fevrier":
                    Console.WriteLine(fujita["Fevrier"]);
                    break;
                case "Mars":
                    Console.WriteLine(fujita["Mars"]);
                    break;
                case "Avril":
                    Console.WriteLine(fujita["Avril"]);
                    break;
                case "Mai":
                    Console.WriteLine(fujita["Mai"]);
                    break;
                case "Juin":
                    Console.WriteLine(fujita["Juin"]);
                    break;
                case "Juillet":
                    Console.WriteLine(fujita["Juillet"]);
                    break;
                case "Aout":
                    Console.WriteLine(fujita["Aout"]);
                    break;
                case "Septembre":
                    Console.WriteLine(fujita["Septembre"]);
                    break;
                case "Octobre":
                    Console.WriteLine(fujita["Octobre"]);
                    break;
                case "Novembre":
                    Console.WriteLine(fujita["Novembre"]);
                    break;
                case "Decembre":
                    Console.WriteLine(fujita["Decembre"]);
                    break;
                default:
                    Console.WriteLine("Erreur");
                    break;
            }
            Console.ReadKey();
        }
    }
}