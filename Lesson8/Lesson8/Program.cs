using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            var ex = new Exception();

            // Exception - start
            // ----------
            // case 1
            //throw new Exception();

            // case 2
            //try
            //{

            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}

            // case 3 - bad practice
            // throw ex;

            // case 4
            // throw new MyCustomException(msg, ex);
            // -------------
            // Exception - end

            // try catch finally
            /* --------------
            try
            {
                // Foo(); // contains potentially dangerous code
            }
            catch (ArgumentsNullExs anex)
            {
                // handle here
            }
            catch (Exception ex)
            {
                // handle here
            }
            finally
            {
                // cleanup  logic here
            }
            */
        }
    }
}
