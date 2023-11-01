using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasess.Interfaces_and_methods
{
    public class ExampleE
    {
        public IEnumerable<int> Foo(IEnumerable<int> numbers, int count)
        {
            foreach (int number in numbers) {
                if (count > 0)
                {
                    count--;
                    yield return number;
                }
            }
        }
    }
}
