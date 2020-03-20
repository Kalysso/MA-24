using System;

namespace Enumeration
{
    class Program
    {
        // Déclaration de l enum 
        public enum Saisons
        {
            printemps,  // Vaut 0
            ete = 4,      // vaut 4
            automne,    // vaut 5
            hiver       // vaut 6
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Une enumeration est un type dont les valeurs sont des entiers. Cela permet d'assigner des valeur entieres à des termes, tout en continuant d'utiliser les termes en question.\n");
            Console.WriteLine("Par defaut, le premier terme vaut 0 et les terme suivants prennent la valeur precedente, incrementee de 1.\n");
            Console.WriteLine("Il est possible de forcer un terme a avoir une certaine valeur ( on ajoute ' = LaValeurSouhaitee'). Les termes suivants (non forcés) seront alors incrementes a partir de cette valeur.\n");

            // Exemple déclaration de l'enum avant le main

            Saisons saisonActuelle = Saisons.printemps;

            Console.WriteLine("Actuellement nous sommes en " + saisonActuelle + ", saison qui vaut " + (int)saisonActuelle);

            Console.WriteLine("Appuyez sur une touche pour fermer la console.");
            Console.ReadKey();
        }
    }
}
