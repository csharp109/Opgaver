using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg6egenskaber2
{
    class Program
    {
        static void Main(string[] args)
        {

            Person test = new Person();
            test.Fornavn= "John";
            test.Efternavn = "Hansen";
            Console.WriteLine(test.FuldtNavn());
            Console.ReadKey();
                                   
        }
    }
}
