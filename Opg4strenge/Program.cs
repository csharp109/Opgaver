using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg4strenge
{
    class Program
    {
        static void Main(string[] args)
        {
           // string fornavn = "Mikkel";
           // string efternavn = "Cronberg";
            string samletnavn = "Mikkel Cronberg";
            string navnStort = samletnavn.ToUpper();
            string navnLille = samletnavn.ToLower();
            string del = samletnavn.Substring(7, 4).ToLower();

            string[] et = samletnavn.Split(' ');

            Console.WriteLine(samletnavn);
            Console.WriteLine(navnStort);
            Console.WriteLine(navnLille);
            Console.WriteLine(del);

            foreach (var item in et)
            {
                Console.WriteLine(item);

            }

            Console.ReadKey();
  
        }
    }
}
