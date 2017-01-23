using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;


namespace Lesson10
{

    public static class StringExtensions {
        public static bool IsNotNull(this string s) {
            //return !string.IsNullOrWhiteSpace(s);
            return !s.Satisfies(string.IsNullOrWhiteSpace);
        }

        public static bool Satisfies(this string s, Func<string, bool> predicate) {
            return predicate(s);
        }
    }

    public static class EmunsExtensions {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> inp, Func<T, bool> predicate) {
            foreach (var e in inp) {
                if (predicate(e)) { yield return e; }
            }
        }
    }

    class Program
    {   



        public MathFunc F { get; set; }

        // the same as
        // public Func<int, int, int> F { get; set; }

        public int Add(int a, int b)
        {
            Console.WriteLine("in add");
            return a + b;

        }

        static bool isEven(int a) { return true; }

        static void Main(string[] args)
        {

            var pr = new Program();
            //pr.F = pr.Add;
            var str = "asdfasdf";
            str.IsNotNull();
            pr.F += Substract;
            pr.F += pr.Add;
            
            var result = pr.F(1, 2);
            Console.WriteLine(result);
            Console.ReadKey();

            var l1 = new List<int>() { 1, 2, 3 };

            var l2 = l1.Select(a => a * 2);

            var allEvens = l1.Where(e => isEven(e));

            foreach (var ae in allEvens)
            {
                Console.WriteLine(ae);
            }

            var allEvens2 = l1.Filter(e => isEven(e));

            Func<int, bool> predicate = (e) => isEven(e);

            Func<int, int, int> add = (a, b) => a + b;

            var filtered = l1.Where(predicate);

            Console.WriteLine(l2);
            Console.ReadKey();

        }

        static int Substract(int a, int b)
        {
            Console.WriteLine("IN Substract");
            return a - b;
        }
    }

    public delegate int MathFunc(int a, int b);
}
