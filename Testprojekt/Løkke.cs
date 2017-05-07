using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testprojekt
{
    class Løkke
    {
        int sum = 0;

        public Løkke(int tal)
        {
            for (int i = 0; i < 10; i++)
            {
                this.sum = sum + tal;
            }
            udskriv();         
        }

        public void udskriv()
        {
            Console.WriteLine(sum);
            Console.ReadKey();
        }


    }
}
