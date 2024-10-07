using System;

namespace ConsoleApplication1
{
    public class Tab
    {
        public void CreerTab(int n)
        {
            int[] tableau = new int[n];
            int cpt = 0;
            foreach (var i in tableau)
            {
                tableau[cpt] = n;
                Console.Write(n + ",");
                n -= 1;
                cpt += 1;
            }
        }
    }
}