using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tab tableau = new Tab();
            
            Console.Write("Quel nombre voulez vous convertir : ");
            int value = int.Parse(Console.ReadLine());
            Console.Write("Voulez-vous convertir en jours (1), en heures (2) ou en minutes (3): ");
            int value2 = int.Parse(Console.ReadLine());
            Console.Write("Quel est la grandeur de base(en jour (1), en heures (2) ou en minutes (3)) : ");
            int value3 = int.Parse(Console.ReadLine());
            tableau.Convertisseur(value, value2, value3);
           
        }
    }
}