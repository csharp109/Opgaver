using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3static
{
    class Program
    {
        static void Main(string[] args)
        {
            int res = LægSammen(5, 2);
            Console.WriteLine(res);
            Udskriv();
           //Udskriv("Dette er en test");
            Console.ReadKey();

        }

        static int LægSammen(int a, int b)
        {
            return a + b;
        }

        
        static void Udskriv(string txt = "test txt")
        {
            Console.WriteLine(txt);
        }

        
    }
}
