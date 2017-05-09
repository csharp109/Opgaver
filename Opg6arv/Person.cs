using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg6arv
{
    public class Person
    {
        public string Fornavn { get; set; }

        public string Efternavn { get; set; }

        public string FuldtNavn()
        {
            return $"{Fornavn} {Efternavn}";
        }

    }

    public class Elev : Person
    {
        public string Klasselokale { get; set; }
        
    }

    public class Instruktør : Person
    {
        public int NøgleId { get; set; }

    }

}
