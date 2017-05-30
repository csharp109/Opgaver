using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opg10_using
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader stream = System.IO.File.OpenText("dyrenavne.txt");
            while(stream.Peek() != -1)
            {
                string navn = stream.ReadLine();
                Console.WriteLine(navn);
            }

            Console.ReadKey();
                    
            stream.Close();
            stream = null;
                     


            using (StreamReader stream2 = System.IO.File.OpenText("dyrenavne.txt"))
            {
                while (stream2.Peek() != -1)
                {
                    string navn = stream2.ReadLine();
                    Console.WriteLine(navn.ToUpper());
                }

            }

            Console.ReadKey();





        }
    }
}
