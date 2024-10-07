using System;
using System.Diagnostics;

namespace ConsoleApplication1
{
    public class Tab
    {
        public void Convertisseur(float nb, int conv, int typeBase)
        {
            float resultat = 0f;
            
            if (conv == 1)
            {
                if (typeBase == 1)
                {
                    resultat = nb;
                }
                else if (typeBase == 2)
                {
                    resultat = nb / 24;
                }
                else
                {
                    resultat = nb / (24 * 60);
                }
                Console.Write(Math.Truncate(resultat*100)/100);
            }
            
            else if (conv == 2)
            {
                if (typeBase == 1)
                {
                    resultat = nb * 24;
                }
                else if (typeBase == 2)
                {
                    resultat = nb;
                }
                else
                {
                    resultat = nb / 60;
                }
                Console.Write(Math.Truncate(resultat*100)/100);
            }
            
            else
            {
                if (typeBase == 1)
                {
                    resultat = nb * 1440;
                }
                else if (typeBase == 2)
                {
                    resultat = nb * 60;
                }
                else
                {
                    resultat = nb;
                }
                Console.Write(Math.Truncate(resultat*100)/100);
            }
        }
    }
}