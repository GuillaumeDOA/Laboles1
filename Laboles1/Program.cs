using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboles1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wil je de datum van vandaag?");
            string Antw = Console.ReadLine().ToLower();

            if (Antw == "ja")
            {
                DateTime datum = DateTime.Now;
                
                
                Console.WriteLine(datum.Date);
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Oke sorry eh beast");
                Console.ReadKey();
            }
        }
    }
}
