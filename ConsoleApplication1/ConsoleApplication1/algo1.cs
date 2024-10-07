using System;

namespace ConsoleApplication1
{
    public class algo1
    {
        public void Solve(int nb)
        {
            if (nb >= 6 && nb <= 874)
            {
                for (int i = 6; i < nb; i++)
                {
                    if (i % 3 == 0 || i % 4 == 0)
                    {
                        Console.Write("C");
                    }
                    if (i % 7 == 0 || i % 18 == 0)
                    {
                        Console.Write("A");
                    }
                    if (i % 42 == 0)
                    {
                        Console.Write("CA");
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}