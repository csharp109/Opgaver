using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testprojekt2
{
    class Program
    {
        static void Main(string[] args)
        {

            //initialisering af array, skal være længde på f. eks [5]
            int[] myarray = new int[5];
            myarray[2] = 33;
            Console.WriteLine(myarray[2]);
            Console.ReadKey();

            //eller denne måde

            int[] array2 = { 6, 4, 10, 33, 2 };
            array2[2] = 10;
            Console.WriteLine(array2[2]);
            Console.ReadKey();

            //array2 kommer til at pege(reference) på myarray , derfor slår 100 igennem på udskrift
            array2 = myarray; //peger kun på myarray
            myarray[3] = 100;
            Console.WriteLine(array2[3]);
            Console.ReadKey();

            // der udskrives sand eller falsk, i det her tilfælde falsk da det er referencer til arrayene
            int[] liste = { 10, 4, 3, 6, 11, 9, 8 };
            int[] copyliste = { 10, 4, 3, 6, 11, 9, 8 };
            Console.WriteLine(liste == copyliste);
            Console.ReadKey();

            //med $ virker det
            string firstname = "peter";
            string lastname = "hansen";
            string name = $"{firstname} {lastname}";
            Console.WriteLine(name);
            Console.ReadKey();

            string s1 = "Hello!";
            string s2 = "Hello!";
            string t = "YO!";
            Console.WriteLine(s1 == s2); //giver true
            Console.ReadKey();
            Console.WriteLine(s1 == "HELLO"); //giver false
            Console.ReadKey();
            Console.WriteLine(s1.Equals(t)); //giver false
            Console.ReadKey();
            Console.WriteLine(t.Equals("YO!")); //giver true
            Console.ReadKey();
            Console.WriteLine("YO!".Equals(t)); //giver true
            Console.ReadKey();

            //string operation return copies of string, derfor skal outputtet over i anden string
            String s4;
            string s3 = "Hello";
            s4 = s3.ToUpper();
            Console.WriteLine(s3 == "HELLO"); //giver false
            Console.WriteLine(s4 == "HELLO"); //giver true
            Console.WriteLine("s3: " + s3);
            Console.WriteLine("s4: " + s4);
            Console.ReadKey();

            Console.WriteLine("1 [C#], 2 [VB]");
            string longchoice = Console.ReadLine();
            int n = int.Parse(longchoice);
            switch(n)
            {
                case 1:
                    Console.WriteLine("Godt valg, det bedste programmeringssprog");
                    break;
                case 2:
                    Console.WriteLine("Du valgte VB");
                    break;
                default:
                        Console.WriteLine("Held og lykke, du valgte hverken 1 eller 2");
                    break;
            }
            Console.ReadKey();


            /////////virker ikke hvorfor?????????????kan ikke finde coolvalue

            int cv = 0;
            Values Coolvalue = new Values();
            //cv = Coolvalue();
            Console.WriteLine(cv);


            //virker ikke??????????

            // static void Twice( int x )
            //{
            //    x = 2 * x;
            // }

            // int i = 42;
            //Twice( i );
            //Console.WriteLine( i );
            
                 
                     


         


        }
               
               
    }

}
