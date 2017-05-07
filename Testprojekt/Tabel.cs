using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testprojekt
{
    class Tabel
    {
        int sum;
        int[] tal = { 1, 4, 6 , 11, 100, 23, 1,6, 9,5};

        public Tabel()
        {
            for (int i = 0; i < tal.Length; i++)
            {
                this.sum = this.sum + tal[i];

            }
            udskriv();

        }

        public void udskriv()
        {

            Console.WriteLine("Tabellens samlede sum er: " + sum);
            Console.ReadKey();
        }

        

    }
}
