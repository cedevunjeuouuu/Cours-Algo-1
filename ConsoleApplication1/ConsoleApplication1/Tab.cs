using System;

namespace ConsoleApplication1
{
    public class Tab
    {
        public void CreerTab(int n)
        {
            int[] tableau = new int[n];
            int cpt = 0;
            for (int i = tableau.Length; i > 0; i -= 2)
            {
                tableau[cpt] = i;
                Console.Write(i+",");
                cpt -= cpt;
            }
        }
    }
}