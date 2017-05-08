using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg6metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res);

            double res2 = BeregnAreal(5);
            Console.WriteLine(res2);

            Udskriv();
            Udskriv("Dette er en test");

            double res3 = BeregnMoms(100.35);
            Console.WriteLine(res3);

            double res4 = BeregnMoms(100.35, 0.25);
            Console.WriteLine(res3);

            int[] løn = { 10000, 5000, 30000 };
            Double gns = Gennemsnit(løn);
            Console.WriteLine(gns);


            Console.ReadKey();

        }



        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        static double BeregnAreal(int radius)
        {
            return ((radius * radius) * System.Math.PI);
        }

        //default txt værdi er tom 
        static void Udskriv(string txt = "")
        {
            Console.WriteLine(txt);

        }

        static double BeregnMoms(double beløb, double momsPct = 0.25)
        {
            return beløb * momsPct;

        }

        static double Gennemsnit(int[] månedsløn)
        {
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum = sum + månedsløn[i];

            }
           sum = (sum / månedsløn.Length);
            return sum;
        }       
        
        //static int BeregnOgSorterArray(int array)
        //{

        //}


    }
}
