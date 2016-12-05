using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            // simple test
            int n = 5;
            Console.WriteLine($"Test - Int {n}");

            /*
            Learn and know how to use string.Format against primitive number and datetime types (int, double, decimal, DateTime)
            Print out variables of each type in most used formats(currency, fixed decimal part -0.2356, exponential, datetime in 24hr format, 12hr format, with/ without timezone, short-long datetime)

            Apply the same to string interpolation approach.
            */

            int i = 10;
            double d = 20.50;
            decimal dec = (decimal)d;
            DateTime date = DateTime.Now;

            string sf = String.Format("Here are several variables: int - {0}, double - {1}, decimal - {2} and date - {3}", i, d, dec, date);

            Console.WriteLine(sf);
            Console.WriteLine("Int string \'currency - default\' format - {0:C}", i);
            Console.WriteLine("Int string \'currency - 0\' format - {0:C0}", i);
            Console.WriteLine("Int string \'currency - 1\' format - {0:C1}", i);
            Console.WriteLine("Int string \'currency - 2\' format - {0:C2}", i);

            Console.WriteLine("Int string \'fixed - deafault\' format - {0:F}", i);
            Console.WriteLine("Int string \'fixed - 0\' format - {0:F0}", i);
            Console.WriteLine("Int string \'fixed - 1\' format - {0:F1}", i);
            Console.WriteLine("Int string \'fixed - 2\' format - {0:F2}", i);
            Console.WriteLine("Int string \'fixed - 3\' format - {0:F3}", i);

            Console.WriteLine("Int string \'exponential\' format - {0:E}", i);

            Console.WriteLine("Int string \'number - default\' format - {0:N}", i);
            Console.WriteLine("Int string \'number - 1\' format - {0:N1}", i);
            Console.WriteLine("Int string \'number - 2\' format - {0:N2}", i);


            Console.WriteLine("Int string \'decimal - default\' format - {0:D}", i);
            Console.WriteLine("Int string \'decimal - 5\' format - {0:D5}", i);

            Console.WriteLine("Int string \'percent - default\' format - {0:P}", i);
            Console.WriteLine("Int string \'percent - 1\' format - {0:P1}", i);
            Console.WriteLine("Int string \'percent - 2\' format - {0:P2}", i);

            Console.WriteLine("Int string \'hex decimal\' format - {0:X}", i);
            Console.WriteLine("Int string \'hex a decimal\' format - {0:x8}", i);

            Console.WriteLine("Int string \'custom\' format - {0:test-##.9999}", i);

            Console.ReadKey();
        }

        static void TypeRepresentation()
        {
        }
    }
}
