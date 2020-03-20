using System;

namespace Tableaux1D
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercice de recherche sur les tableaux (1D) en C# :\n\n");
            Console.WriteLine("Declaration de tableaux (sans initialisation) : type[] nom = new type[n]; \n");
            Console.WriteLine("Declaration avec initialisation explicite de la taille : type[] = new type[] {ensemble des valeurs}\n");
            Console.WriteLine("Declaration avec initialisation implicite de la taille : type[] nom = {ensemble des valeurs}; \n");
            Console.WriteLine("Assignation avec une valeure literale : nom[index] = valeur\n");
            Console.WriteLine("Assignation avec un autre tableau: tableau1 = tableau2\n");

            // Exemple simple d'utilisation
            string[] menagerie = new string[5];
            string[] animaux = new string[] { "chats", "chiens", "poissons", "chevaux", "moutons" };

            menagerie = animaux;
            menagerie[2] = "ânes";

            Console.WriteLine("C'est une vrai ménagerie ! On y trouve :\n");
            for (int i = 0; i < menagerie.Length; i++){
                Console.WriteLine(" - " + menagerie[i]);
            }

            Console.WriteLine("Appuyez sur une touche pour fermer la console.");
            Console.ReadKey();
        }
    }
}
