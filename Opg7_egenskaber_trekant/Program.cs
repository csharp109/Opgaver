using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg7_egenskaber_trekant
{
    class Program
    {
        static void Main(string[] args)
        {
            Trekant t = new Trekant(4, 6);
            Console.WriteLine(t);
            Console.ReadKey();
        }
    }
}
