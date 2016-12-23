using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Lesson6.Annotations;

namespace Lesson6
{
    public class MyList<T>
    {
        private T[] _array;

        public T this[int i]
        {
            get
            {
                // This indexer is very simple, and just returns or sets
                // the corresponding element from the internal array.
                if (i <= 0)
                    throw new IndexOutOfRangeException();
                return _array[i - 1];
            }
            set
            {
                if (i <= 0 && i > _array.Length)
                    throw new IndexOutOfRangeException();
                _array[i - 1] = value;
            }
        }
    }

    public class MyDict<TKey, TValue>
    {
        private IDictionary<TKey, TValue> _dictionary;

        public TValue this[TKey key]
        {
            get { return _dictionary[key]; }
        }

    }



    public class MyDictString : MyDict<string, int>
    {
        

    }

    // test

    public class Base
    {
        public virtual void M1()
        {
            Console.WriteLine("Base - Method 1");
        }
        public virtual void M2()
        {
            Console.WriteLine("Base - Method 2");
        }
    }

    public class Test:Base
    {
        public override void M1()
        {
            Console.WriteLine("Test - Method 1");
        }
        public new void M2()
        {
            Console.WriteLine("Test - Method 2");
        }
    }

    class Eventtest
    {
        public event EventHandler TestChanged;

        private int _test;

        public int Test
        {
            get { return _test; }
            set
            {
                _test = value;

                onPropChanged();
            }
        }

        private void onPropChanged()
        {
            TestChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    class Evttst:INotifyPropertyChanged
    {
        private int _a;
        public int A
        {
            get { return _a; }
            set
            {
                _a = value;
                OnPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    class simpleEvtCase
    {
        public event EventHandler PropChanged;
        public int A;
        public void SetA(int a)
        {
            A = a;
            RisePropChange();
        }

        public void RisePropChange()
        {
            PropChanged?.Invoke(this, EventArgs.Empty);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Base b = new Base();
            Test t = new Test();
            Base bt = new Test();


            b.M1();
            b.M2();
            t.M1();
            t.M2();
            bt.M1();
            bt.M2();

            /*
             Output:
             Base - Method 1
             Base - Method 2
             Test - Method 1
             Test - Method 2
             Test - Method 1
             Base - Method 2
             */

            var test = new Eventtest();
            var tst = new Evttst();
            var simple = new simpleEvtCase();

            test.TestChanged += OnTestChanged;
            test.Test = 10;

            tst.PropertyChanged += OnPropChanged;
            tst.A = 11;

            simple.PropChanged += SimplePropChange;
            simple.SetA(15);

            Console.ReadKey();
        }

        private static void OnPropChanged(object sender, PropertyChangedEventArgs e)
        {
            if (e.PropertyName == "A")
            {
                var mc = sender as Evttst;
                if (mc != null)
                {
                    Console.WriteLine($"Property {e.PropertyName} changed - {mc.A}");
                }
            }
        }

        private static void OnTestChanged(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Test changed");
        }

        private static void SimplePropChange(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Simple case");
        }
    }
    /*
public class MyClass
    {
        public event EventHandler AChanged;

        public int A { get; set; }

        public void Foo(int a)
        {
            A = a;
            RaiseAChanged();
        }

        private void RaiseAChanged()
        {
            var handler = AChanged;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
        }
    }

    public class MyClass2
    {
        public event EventHandler<AChangedEventArgs> AChanged;

        public int A { get; set; }

        public void Foo(int a)
        {
            A = a;
            RaiseAChanged();
        }

        private void RaiseAChanged()
        {
            var handler = AChanged;
            if (handler != null)
            {
                handler(this, new AChangedEventArgs(A));
            }
        }
    }

    public class AChangedEventArgs : EventArgs
    {
        public int A { get; }

        public AChangedEventArgs(int a)
        {
            A = a;
        }
    }

    public class MyClass3 : INotifyPropertyChanged
    {
        private int _a;

        public int A
        {
            get { return _a; }
            set
            {
                _a = value;
                
                OnPropertyChanged();
                OnPropertyChanged("B");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var myClass = new MyClass();
            myClass.AChanged += MyClassOnAChanged1;
            myClass.AChanged += MyClass_AChanged2;
            myClass.Foo(1);
            Console.WriteLine("-------");
            myClass.AChanged -= MyClassOnAChanged1;
            myClass.AChanged -= MyClassOnAChanged1;
            myClass.Foo(2);
            Console.WriteLine("-------");
            var myClass2 = new MyClass2();
            myClass2.AChanged += MyClass2_AChanged;

            myClass2.Foo(3);

            Console.WriteLine("-------");

            var myclass3 = new MyClass3();
            myclass3.PropertyChanged += Myclass3_PropertyChanged;
            myclass3.A = 4;
            Console.ReadKey();
        }

        private static void Myclass3_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            
            if (e.PropertyName == "A")
            {
                var mc = sender as MyClass3;
                if (mc != null)
                {
                    Console.WriteLine($"PropertyChanged: {e.PropertyName} = {mc.A}");
                }
            }
            if (e.PropertyName == "B")
            {
                Console.WriteLine($"PropertyChanged: B is not defined");
            }
        }

        private static void MyClass2_AChanged(object sender, AChangedEventArgs e)
        {
            var myClass2 = sender as MyClass2;
            if (myClass2 != null)
            {
                Debug.Assert(myClass2.A == e.A);
            }
            Console.WriteLine($"In on changed to A = {e.A}");
        }

        private static void MyClass_AChanged2(object sender, EventArgs e)
        {
            Console.WriteLine("In on changed 2");
        }

        private static void MyClassOnAChanged1(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("In on changed 1");
        }
    } 

     */
}
