using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg01HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Indtast navn");
            string navn = Console.ReadLine();
            navn = navn.ToUpper();
            Console.WriteLine("Velkommen " + navn);
            Console.WriteLine("Tryk på en tast for at fortsætte");
            Console.ReadKey();
            // dshfdsajhijsafddsak
            //nkdsfkdsafdsa

        }
    }
}
