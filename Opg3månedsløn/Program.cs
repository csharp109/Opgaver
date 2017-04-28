using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg3månedsløn
{
    class Program
    {
        
        static void Main(string[] args)
        {

            double sum = 0;

            double[] lon = { 2000.23, 12000, 33000.75, 23100, 4000, 200000 };
            
            //Usorteret array
            Console.WriteLine();
            Console.WriteLine("Usorteret array:");
            Console.WriteLine();


            for (int i = 0; i < lon.Length; i++)
            {
                Console.WriteLine(lon[i]);
                sum = sum + lon[i];
            }


            //sorteret array
            Array.Sort(lon);

            Console.WriteLine();
            Console.WriteLine("Sorteret array:");
            Console.WriteLine();

            sum = 0;

            for (int i = 0; i < lon.Length; i++)
            {
                Console.WriteLine(lon[i]);
                sum = sum + lon[i];
            }



            double sum2 = sum / lon.Length;
            Console.WriteLine("Gennemsnit " + sum2.ToString("N2"));
            Console.ReadKey();


        }
    }
}
