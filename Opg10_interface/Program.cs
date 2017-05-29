using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg10_interface
{
    class Program
    {
        static void Main(string[] args)
        {
            IDbFunktioner[] array = new IDbFunktioner[4];
            array[0] = new Hund();
            array[1] = new Ubåd();
            array[2] = new Hund();
            array[3] = new Ubåd();
            foreach (var item in array)
            {
                item.Gem();
            }
        }

        class Hund : IDbFunktioner
        {
    
            public string Navn { get; set; }

            public void Gem()
            {
              
                {
                    Console.WriteLine("Gemmer hund ....");
                    Console.ReadKey();
                }
               
            }
        }

        class Ubåd : IDbFunktioner
        {
            public int Nummer { get; set; }
            public double Tubine { get; set; }

            public void Gem()
            {
                Console.WriteLine("Gemme ubåd....");
                Console.ReadKey();
            }
        }


    }
}
