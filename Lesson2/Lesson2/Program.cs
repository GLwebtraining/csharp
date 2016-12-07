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
            intStringFormat(i);
            doubleStringFormat(d);
            decimalStringFormat(dec);
            dateStringFormat(date);

            Console.WriteLine("--- interpolation ---");
            Console.WriteLine($"int - Currency {i:C}, {i:C3}; Fixed {i:F}; Percent {i:P}");
            Console.WriteLine($"double - Currency {d:C}, {d:C3}; Fixed {d:F}; Percent {d:P}");
            Console.WriteLine($"decimal - Currency {dec:C}, {dec:C3}; Fixed {dec:F}; Percent {dec:P}");
            Console.WriteLine($"date - Long {date:D}; Short {date:d}; General {date:g}; Custom {date:yy-MMM-dd ddd}");

            Console.ReadKey();
        }

        static void intStringFormat(int i)
        {
            Console.WriteLine("int");
            Console.WriteLine("-----------");
            Console.WriteLine("\'currency - default\' format - {0:C}", i);
            Console.WriteLine("\'currency - 0\' format - {0:C0}", i);
            Console.WriteLine("\'currency - 1\' format - {0:C1}", i);
            Console.WriteLine("\'currency - 2\' format - {0:C2}", i);

            Console.WriteLine("\'fixed - deafault\' format - {0:F}", i);
            Console.WriteLine("\'fixed - 0\' format - {0:F0}", i);
            Console.WriteLine("\'fixed - 1\' format - {0:F1}", i);
            Console.WriteLine("\'fixed - 2\' format - {0:F2}", i);
            Console.WriteLine("\'fixed - 3\' format - {0:F3}", i);

            Console.WriteLine("\'exponential\' format - {0:E}", i);

            Console.WriteLine("\'number - default\' format - {0:N}", i);
            Console.WriteLine("\'number - 1\' format - {0:N1}", i);
            Console.WriteLine("\'number - 2\' format - {0:N2}", i);

            Console.WriteLine("\'decimal - default\' format - {0:D}", i);
            Console.WriteLine("\'decimal - 5\' format - {0:D5}", i);

            Console.WriteLine("\'percent - default\' format - {0:P}", i);
            Console.WriteLine("\'percent - 1\' format - {0:P1}", i);
            Console.WriteLine("\'percent - 2\' format - {0:P2}", i);

            Console.WriteLine("\'hex decimal\' format - {0:X}", i);
            Console.WriteLine("\'hex a decimal\' format - {0:x8}", i);
            Console.WriteLine("\'custom\' format - {0:test-##.9999}", i);
        }

        static void doubleStringFormat(double i)
        {
            Console.WriteLine("double");
            Console.WriteLine("-----------");
            Console.WriteLine("\'currency - default\' format - {0:C}", i);
            Console.WriteLine("\'currency - 0\' format - {0:C0}", i);
            Console.WriteLine("\'currency - 1\' format - {0:C1}", i);
            Console.WriteLine("\'currency - 2\' format - {0:C2}", i);

            Console.WriteLine("\'fixed - deafault\' format - {0:F}", i);
            Console.WriteLine("\'fixed - 0\' format - {0:F0}", i);
            Console.WriteLine("\'fixed - 1\' format - {0:F1}", i);
            Console.WriteLine("\'fixed - 2\' format - {0:F2}", i);
            Console.WriteLine("\'fixed - 3\' format - {0:F3}", i);

            Console.WriteLine("\'exponential\' format - {0:E}", i);

            Console.WriteLine("\'number - default\' format - {0:N}", i);
            Console.WriteLine("\'number - 1\' format - {0:N1}", i);
            Console.WriteLine("\'number - 2\' format - {0:N2}", i);

            Console.WriteLine("\'percent - default\' format - {0:P}", i);
            Console.WriteLine("\'percent - 1\' format - {0:P1}", i);
            Console.WriteLine("\'percent - 2\' format - {0:P2}", i);
            
            Console.WriteLine("\'custom\' format - {0:test-##.9999}", i);
        }

        static void decimalStringFormat(decimal i)
        {
            Console.WriteLine("decimal");
            Console.WriteLine("-----------");
            Console.WriteLine("\'currency - default\' format - {0:C}", i);
            Console.WriteLine("\'currency - 0\' format - {0:C0}", i);
            Console.WriteLine("\'currency - 1\' format - {0:C1}", i);
            Console.WriteLine("\'currency - 2\' format - {0:C2}", i);

            Console.WriteLine("\'fixed - deafault\' format - {0:F}", i);
            Console.WriteLine("\'fixed - 0\' format - {0:F0}", i);
            Console.WriteLine("\'fixed - 1\' format - {0:F1}", i);
            Console.WriteLine("\'fixed - 2\' format - {0:F2}", i);
            Console.WriteLine("\'fixed - 3\' format - {0:F3}", i);

            Console.WriteLine("\'exponential\' format - {0:E}", i);

            Console.WriteLine("\'number - default\' format - {0:N}", i);
            Console.WriteLine("\'number - 1\' format - {0:N1}", i);
            Console.WriteLine("\'number - 2\' format - {0:N2}", i);
            
            Console.WriteLine("\'percent - default\' format - {0:P}", i);
            Console.WriteLine("\'percent - 1\' format - {0:P1}", i);
            Console.WriteLine("\'percent - 2\' format - {0:P2}", i);

            Console.WriteLine("\'custom\' format - {0:test-##.9999}", i);
        }

        static void dateStringFormat(DateTime i)
        {
            Console.WriteLine("date");
            Console.WriteLine("-----------");
            Console.WriteLine("\'long date\' format - {0:D}", i);
            Console.WriteLine("\'short date\' format - {0:d}", i);
            Console.WriteLine("\'full long date\' format - {0:F}", i);
            Console.WriteLine("\'full short date\' format - {0:f}", i);
            Console.WriteLine("\'general long\' format - {0:G}", i);
            Console.WriteLine("\'general short\' format - {0:g}", i);
            Console.WriteLine("\'month\' format - {0:M}", i);
            Console.WriteLine("\'universal\' format - {0:u}", i);
            Console.WriteLine("\'custom\' format - {0:yy-MMM-dd ddd}", i);
        }
    }
}
