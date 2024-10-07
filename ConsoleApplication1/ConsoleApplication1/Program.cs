using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Tab tableau = new Tab();
            
            Console.Write("Ecrivez un nombre : ");
            int value = int.Parse(Console.ReadLine());
            tableau.CreerTab(value);
           
        }
    }
}