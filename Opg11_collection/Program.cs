using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg11_collection
{
    class Program
    {
        static void Main(string[] args)
        {

            List < Person> liste1 = new List<Person>();
            liste1.Add(new Person() { Id = 1, Navn = "Kurt" });
            liste1.Add(new Person() { Id = 2, Navn = "Aage" });
            liste1.Add(new Person() { Id = 3, Navn = "Mia" });

        
            foreach ( var item in liste1)
            {
                Console.WriteLine(item.Navn);
            }
            Console.ReadKey();

            Dictionary<int, Person> liste2 = new Dictionary<int, Person>();
            liste2.Add(1, new Person() { Id = 1, Navn = "Kurt" });
            liste2.Add(4, new Person() { Id = 2, Navn = "Aage" });
            liste2.Add(7, new Person() { Id = 3, Navn = "Mia" });

            var p = liste2[4];
            Console.WriteLine(p.Navn);
            Console.ReadKey();

            List<Bil> Billiste = new List<Bil>();
            Billiste.Add(new Bil() { Nr = 1, Km = 120000, Mærke = "Ford" });
            Billiste.Add(new Bil() { Nr = 2, Km = 130000, Mærke = "Fiat" });
            Billiste.Add(new Bil() { Nr = 3, Km = 20000, Mærke = "Toyota" });

            foreach (var item in Billiste)
            {
                Console.WriteLine(item.Nr  + item.Mærke + item.Km);
            }
            Console.ReadKey();

        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Navn { get; set; }
    }


    class Bil
    {
        public int Nr { get; set; }
        public string Mærke { get; set; }
        public int Km { get; set; }
    }
}
