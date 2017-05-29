using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg9_fejl_håndtering
{
    class Program
    {
        static void Main(string[] args) 
        {

            try
            {
                Run();
            }
            catch (Exception fejl)
            {
                Console.WriteLine("Der er sket en fejl.....: " + fejl );
                Console.ReadKey();
               // if(fejl.InnerException != null)
                //{
                 //   Console.WriteLine("Der er sket en innerexception");
                  //  Console.ReadKey();
               // }
                // throw;
            }

            
            finally
            {
                Console.WriteLine("Finally");
                Console.ReadKey();
            }


        }

        private static void Run()
        {
            Console.WriteLine("Indtast 1. tal");
            int tal1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("indtast 2. tal ");
            int tal2 = Convert.ToInt32(Console.ReadLine());
            int res = tal1 + tal2;
            Console.WriteLine("resultatet er " + res);
            Console.ReadKey();
        }
    }
}
