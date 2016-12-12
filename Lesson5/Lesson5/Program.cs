using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5
{
    class A
    {
        public virtual void Foo()
        {
            Console.WriteLine("A");
        }
    }

    class B:A
    {
        // ERROR! public virtual override void Foo() - Override method cannot be marked as virtual
        public override void Foo()
        {
            Console.WriteLine("B");
        }
    }

    class C:B
    {
        public override void Foo()
        {
            Console.WriteLine("C");
        }
    }

    class D:A
    {
        // without virtual
        public void Foo()
        {
            Console.WriteLine("D");
        }
    }

    public abstract class Base
    {
        public virtual void Foo()
        {
            Console.WriteLine("Abstract Base");
        }
    }

    public class Test:Base
    {
        public virtual void Foo()
        {
            Console.WriteLine("Abstract Test:Base");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var a = new A();
            var b = new B();
            var c = new C();
            var d = new D();

            a.Foo(); // A - in both cases
            b.Foo(); // B - in both cases
            c.Foo(); // C - in both cases
            d.Foo(); // D - in both cases

            Console.WriteLine("------- 1 ------");

            A ab = new B(); // in case using "public override void Foo" -> "B", in case using "public virtual void Foo" -> "A"
            A ac = new B(); // in case using "public override void Foo" -> "B", in case using "public virtual void Foo" -> "A"
            A bc = new C(); // in case using "public override void Foo" -> "C", in case using "public virtual void Foo" -> "A"
            A da = new D(); // "A" - in both cases

            ab.Foo();
            ac.Foo();
            bc.Foo();
            da.Foo();

            Console.WriteLine("------ 2 -------");

            B test1 = new C();
            A test2 = new D();
            D test3 = new D();

            test1.Foo(); // in case using "public override void Foo" -> "C", in case using "public virtual void Foo" -> "B"
            test2.Foo(); // in case using "public override void Foo" -> "A", in case using "public virtual void Foo" -> "A"
            test3.Foo(); // in case using "public void Foo" -> "D", in case using "public void Foo" -> "D"

            Console.WriteLine("------ 3 -------");

            var temp = new Test();
            temp.Foo();

            Console.ReadKey();
        }
    }
}
