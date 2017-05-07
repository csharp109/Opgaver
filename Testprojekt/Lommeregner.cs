using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testprojekt
{
    class Lommeregner
    {
        string navn;
        int tal1, tal2, sum;


        public Lommeregner(string navn, int tal1, int tal2)
        {
            this.navn = navn;
            this.tal1 = tal1;
            this.tal2 = tal2;
            regn();
            udskriv();
        }
        
        public void regn()
        {
            sum = tal1 + tal2;
            
        }

        public void udskriv()
        {
            Console.WriteLine(sum);
            Console.ReadKey();
        }


    }
}
