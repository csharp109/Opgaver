using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg5terning
{
    class Program
    {
        static void Main(string[] args)
        {
           
            //Terning t1;
            //t1 = new Terning();
            //Terning t2;
            //t2 = new Terning();

            var t1 = new Terning();
            var t2 = new Terning();


            Console.WriteLine("default construktor: " + t1.værdi);
            Console.WriteLine("custom construktor: " + t2.værdi);

            t2 = t1;
            Console.WriteLine("default construktor efter t2=t1: " + t1.værdi);
            Console.WriteLine("custom construktor efter t2=t1 " + t2.værdi);

            t1.værdi = 1;
            Console.WriteLine("default construktor efter (t1.værdi=1) " + t1.værdi);
            Console.WriteLine("custom construktor efter (t1.værdi=1) " + t2.værdi);

            t2.værdi = 8;
            Console.WriteLine("default construktor efter (t2.værdi=8) " + t1.værdi);
            Console.WriteLine("custom construktor efter (t2.værdi=8) " + t2.værdi);




            Console.ReadKey();

        }
                       
    }
}
