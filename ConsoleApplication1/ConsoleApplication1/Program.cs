using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            algo1 algo = new algo1(); 
            Console.Write("Ecrivez un nombre entre 6 et 874 : ");
            int value = int.Parse(Console.ReadLine());
            algo.Solve(value);
        }
    }
}