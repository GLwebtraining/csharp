using System;

namespace Lesson4
{
    class MyClass
    {
        public int A = 5;
    }

    class Program
    {
        static void Test(int a, MyClass v, ref int b, out int c)
        {
            int e = 4;
            a = 7;
            b = 8;
            v.A = 9;
            c = 0;

            Console.WriteLine($"local {a}, MyClass {v.A}");
        }

        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 3;

            var myVar1 = new MyClass();
            var myVar2 = new MyClass();

            Console.WriteLine($"value type - {a},{b}, reference type - {myVar2.A}");

            Test(a, myVar1, ref b, out c);

            Console.WriteLine($"value type - {a}, {b}, refer.type - {myVar1.A}, {myVar2.A}");

            Console.ReadKey();
        }
    }
}
