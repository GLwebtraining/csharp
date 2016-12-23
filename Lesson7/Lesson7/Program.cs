using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson7
{

    class Test
    {
        void Foo()
        {
            this.MemberwiseClone();
           
        }

        private int A { get; set; }

        public override string ToString()
        {
            return $"Test - A:{A}";
        }
    }

    class MyGeneric<T, TResult, TValue>
    {
        public T Value { get; set; }

        public MyGeneric(T value)
        {
        }

    }

    class MyGen1<T, TRes, TVal, TEnumerable> 
        where T : struct
        where TVal: class
        where TRes: new()
        where TEnumerable: IEnumerable
    {
        TRes Foo()
        {
            return new TRes();
        }
    }

    class MyClass
    {
        public MyClass()
        {
        }

        public interface ISerializer
        {
            T Deserializer<T> (string json);
            string Serializer<T>(T obj);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var t = new Test();
            var t1 = new Test();


            var ex = new MyGeneric<string, int, bool>("a");
            var ints = new MyGeneric<int, string, bool>(5);

            var tt = new MyGen1<int, MyClass, string>();

            Console.WriteLine(t.ToString());
            Console.ReadKey();
            t.Equals(t1);
            t.GetHashCode();
            
        }
    }
}
