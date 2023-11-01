using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#nullable enable

namespace TestClasess.Interfaces_and_methods
{
    public class ExampleD
    {
        public void Foo(int i, string? str)
        {
            if (i == -1 || i == 1)
            {
                throw new ArgumentException("i equals -1 or 1.", nameof(i));
            }
            if (i == -10 || i == 10)
            {
                throw new ArgumentOutOfRangeException(nameof(i));
            }
            if (str is null)
            {
                throw new ArgumentNullException(nameof(str));
            }
            Console.Write("1");
        }

        public void Bar(int i, string? str)
        {
            try
            {
                Foo(i, str);
            }
            catch(ArgumentNullException)
            {
                Console.Write("2");
            }
            catch(Exception)
            {
                Console.Write("3");
            }
            finally
            {
                Console.Write("4");
            }
        }
    }
}
