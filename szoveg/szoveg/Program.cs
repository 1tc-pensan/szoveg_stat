using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szoveg
{
    class Program
    {
        static int Szoszam(string sz)
        {
            int szam = 0;
            for (int i = 0; i < sz.Length; i++)
            {
                if (sz[i]==' ')
                {
                    szam++;
                }
            }
            return szam;
        }
        /*static string ReduceSpaces(string origin)
        {
            string result = origin.Trim();
            //Ötlet: Replace 2 szóközöket 1-re cseréljük, amig van 2 szóköz
            while (result.IndexOf("  ") != -1)
            {
                result = result.Replace("  ", " ");
            }
            return result;
        }*/
        static string Visszafele(string sz)
        {
            for (int i = sz.Length-1; i > 0; i--)
            {

            }
        }
        static void Main(string[] args)
        {
            //0.
            Console.Write("Be:");
            string szoveg = Console.ReadLine();
            //Console.WriteLine($"Beirt szoveg:{szoveg}");
            //1.
            int szoszam=Szoszam(szoveg);
            Console.Write(szoszam);
            Console.ReadKey();
            //2.
            string visszafele = szoveg;
            string Vissza=Visszafele(string szoveg)
        }
    }
}
