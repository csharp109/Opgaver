using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opg2variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            int heltal = 10;
            heltal++;
            Console.WriteLine(heltal);
            heltal--;
            Console.WriteLine(heltal);
            //lægger 20 til heltal
            heltal += 20;
            Console.WriteLine(heltal);

            ///**********************************************
            ///

            double kommatal = 12.5;
            kommatal++;
            Console.WriteLine(kommatal);
            kommatal--;
            Console.WriteLine(kommatal);
            //ganger med 2
            kommatal *= 2;
            Console.WriteLine(kommatal);
            

            ///**********************************************
            ///
            Filtyper ft = Filtyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int) ft);

            ///**********************************************
            ///

            DateTime dato = DateTime.Now;
            //formatering af dato output
            Console.WriteLine(dato.ToString("ddMMyy"));

            ///**********************************************
            ///

            Person p;
            p.Id = 1;
            p.Navn = "Mikkel";
            Console.WriteLine(p.Navn);

            Console.ReadKey();
        }

        

    }
    public enum Filtyper
    {
        csv,
        pdf,
        txt
    }

    public struct Person
    {
        public int Id;
        public string Navn;
    }
}
