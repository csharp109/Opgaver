using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg6arv
{
    class Program
    {
        static void Main(string[] args)
        {

            //

            //Person p = new Person();
            //Console.WriteLine(p.FuldtNavn{ Fornavn = "Jens", Efternavn = "Hansen"});
            Person p = new Person() { Fornavn = "Jens", Efternavn = "Hansen" };
            Console.WriteLine(p.FuldtNavn());

            Elev e = new Elev() { Fornavn = "Jens", Efternavn = "Hansen", Klasselokale = "B" };
            Console.WriteLine(e.FuldtNavn() + "dette er klasselokale " + e.Klasselokale);

            Instruktør i = new Instruktør() { Fornavn = "Jens", Efternavn = "Hansen", NøgleId = 11 };
            Console.WriteLine(i.FuldtNavn() + "dette er nøgleid" + i.NøgleId);

            
            Console.ReadKey();
        }
        
    }
}
