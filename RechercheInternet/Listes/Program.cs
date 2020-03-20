using System;
using System.Collections.Generic;

namespace Listes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercice de recherche sur les listes<string> en C# :\n\n");
            Console.WriteLine("Declaration de list<string> (sans initialisation) : IList<string> nom = new List<string>(); \n Il est possible d'utiliser 'List<string>' à la place de 'IList<string>' \n");
            Console.WriteLine("Declaration avec initialisation : IList<string> nom = new List<string>(){ensemble des valeurs}; \n");
            Console.WriteLine("Ajout d'un element dans la liste : nom.Add('valeur');  (Valeur peut être remplacé par 'null' pour ajouter un element vide)");
            Console.WriteLine("Ajout d'une liste d'element: nom.AddRange(nomDeLaListeDontOnDoitAjouterLesElements);");
            Console.WriteLine("Retrait d'un element de la liste : nomListe.Remove(element);");
            Console.WriteLine("Retrait d'un element de la liste a une position : nomListe.RemoveAt(index);");
            Console.WriteLine("Affichage des elements de la liste (sur la console) : foreach (var element in nomListe){ Console.WriteLine(element);} \n");

            List<string> liste = new List<string>(){"chats", "chiens", "poissons", "chevaux", "moutons" };
            List<string> animaux = new List<string>() { "chèvre", "ânes", "vaches" };
            liste.Remove("poissons");
            liste.AddRange(animaux);
            liste.Add("canard");
           

            Console.WriteLine("La liste contient " + liste.Count + " elements : ");

            foreach (var element in liste) {
                Console.WriteLine(element);

            }

            Console.WriteLine("Appuyez sur une touche pour fermer la console.");
            Console.ReadKey();
        }
    }
}
