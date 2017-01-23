using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson11
{
    class Program
    {
        static void Main(string[] args)
        {
            // String - it is a reference type !
            string s = " ";
            s += "1";
            s += "2";
            s += "3";

            // each concatination do allocate memory
            // and it is the same as s = "1" + "2" + "3"
            // better use String.Formar("{0}{1}{2}", "1", "2", "3"); or string interpolation
            // when it has lots of strings to contcatinate (endless) better use StringBuilder

            StringBuilder sb = new StringBuilder();
            sb.Append("1");
            // ...
            sb.ToString();

            // " " - bad , String.Empty - good

            // Array
            byte[] bytes = new byte[10];
            for (int i = 0; i < bytes.Length; i++) { }

            byte[] src = new byte[10];

            byte[] dest = new byte[20];

            // Array.Copy(src, dest); - read about Copy arrays

            byte[,,,] ndim = new byte[1,2,3,4];

            byte[,] dim2 = new byte[1, 2];

            byte[][] jagged = new byte[10][];



            return;
            Console.WriteLine(sb);
            Console.ReadKey();
        }
    }
}
