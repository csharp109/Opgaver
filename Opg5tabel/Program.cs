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
                        
                        Console.Write((x*y) + " ");
                    }

                    else
                    {
                        Console.WriteLine((y * x). + " ");
                    }

                }

            }
            Console.ReadKey();
        }
    }
}
