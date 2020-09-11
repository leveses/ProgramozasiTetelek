using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;

namespace ProgramozasiTetelek
{
    class Program
    {
        static int[] tomb = new int[10] { 12, 7, 2, 4, 45, 99, 1, 8, 95, 50 };
        static void Main(string[] args)
        {
            TombKiiras();
            Console.WriteLine();
            Osszegzes();
            Console.WriteLine();
            Megszamolas();
            Console.ReadKey();
        }

        private static void Megszamolas()
        {
            int s = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                if (tomb[i]%3 == 1)
                {
                    s += 1;
                }
            }
            Console.WriteLine(s + " db van");
        }

        private static void Osszegzes()
        {
            int s = 0;
            for (int i = 0; i < tomb.Length; i++)
            {
                s = s + tomb[i];
            }
            Console.WriteLine(s);
        }

        private static void TombKiiras()
        {
            for (int i = 0; i < tomb.Length; i++)
            {
                Console.Write(tomb[i]+",");
            }
            
        }
    }
}
