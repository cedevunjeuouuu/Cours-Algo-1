using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            algo1 algo = new algo1(); 
            int value = int.Parse(Console.ReadLine());
            algo.Solve(value);
        }
    }
}