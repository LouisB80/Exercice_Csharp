using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercices_4
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //Definir un login et mdp
            String login = "lbh" , password = "123456789", login1, password1;

            //Entrer le login.
            Console.WriteLine("Entrez votre login");
            login1 = Console.ReadLine();

            //Tant que les logins ne correspondent pas.
            while (login != login1)
            {
                Console.WriteLine("Erreur, login inconnu, reessayez !");
                login1 = Console.ReadLine();
            }
            //Enter le mdp
            Console.WriteLine("Entrez votre mot de passe");
            password1 = Console.ReadLine();

            //Tant que les mdps ne correspondent pas.
            while (password != password1)
            {
                Console.WriteLine("Erreur, mot de passe inconnu, reessayez !");
                password1 = Console.ReadLine();
            }
            Console.WriteLine("Bienvenu à la Manu, Amiens.");*/

            String login= "lbh", login2, mdp = "123", mdp2;

            Console.WriteLine("Login");
            login2 = Console.ReadLine();
            Console.WriteLine("Mdp");
            mdp2 = Console.ReadLine();
            //On compare le login entrer et le mot de passe | login.Equals(login2) est équivalent a '=='
            if (login.Equals(login2) && mdp.Equals(mdp2))
            {
                Console.WriteLine("Bienvenu à la manu, Amiens.");
            }
            else
            {
                Console.WriteLine("Mauvais identifiant ou mauvais mot de passe.");
            }
            Console.ReadKey();
        }
    }
}
