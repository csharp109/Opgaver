using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg5terning2
{
    class Program
    {
        static void Main(string[] args)
        {
            Terning t1 = new Terning();
            t1.Skriv();
            t1.Ryst();
            t1.Skriv();

            Console.ReadKey();

            Terning t2 = new Terning(false);
            t2.Skriv();
            t2.Ryst();
            t2.Skriv();

            Console.ReadKey();

        }
    }
}
