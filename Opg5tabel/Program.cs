using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg5tabel
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int x = 1; x < 11; x++)

            {
                for (int y = 1; y < 11; y++)
                {
                    if (y < 10)
                        {

                        string tal1 = (x * y).ToString();
                        if ((x * y) > 50) Console.ForegroundColor = ConsoleColor.Yellow;
                        else Console.ForegroundColor = ConsoleColor.White;

                        Console.Write((tal1.PadLeft(4)) + " ");
                        
                    }

                    else
                    {
                        string tal1 = (x * y).ToString();
                        Console.WriteLine((tal1.PadLeft(4)) + " ");
                        
                    }

                }

            }
            Console.ReadKey();
        }
    }
}
