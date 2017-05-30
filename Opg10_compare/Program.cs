using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg10_compare
{
    class Program
    {
        static void Main(string[] args)
        {

            Hund[] hunde = new Hund[4];
            hunde[0] = new Hund() { Alder = 10, Navn = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Navn = "Lady" };
            hunde[2] = new Hund() { Alder = 8, Navn = "Sommer" };
            hunde[3] = new Hund() { Alder = 25, Navn = "Nick" };
            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                
                Console.Write(item.Alder + " ");
                Console.WriteLine(item.Navn);
            }

            Console.ReadKey();
        }
    }

    class Hund : IComparable
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

      public int CompareTo(object obj)
        {
            Hund h = obj as Hund;
            if (h.Alder > this.Alder)
                return -1;
            if (h.Alder < this.Alder)
                return 1;

            

            return 0;

        }


    }
}
