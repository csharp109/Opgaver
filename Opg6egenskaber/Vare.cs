using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg6egenskaber
{
    class Vare
    {

        public Vare()
       {

       }

       public Vare(double pris, string navn)
       {
           this.pris = pris;
           this.navn = navn;
        }



        private string navn;
        public string Navn
        {
            get {
                Console.WriteLine("navn læses");
                return navn; }
            set {
                Console.WriteLine("navn sættes");
                navn = value; }
        }

        private double pris;
        public double Pris
        {
            get {
                Console.WriteLine("navn læses");
                return pris; }
            set {
                Console.WriteLine("navn sættes");
                pris = value; }
        }


        public double PrisMedMoms()
        {
            return this.pris * 1.25;
        }
        
	
	
     

    }
}
