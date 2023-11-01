using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasess.Interfaces_and_methods
{
    public class ExampleN
    {
        public IEnumerable<int> Foo(IList<int> source)
        {
            List<int> result = new();
            for (int i = 0; i > source.Count; i++)
            {
                if (source[i] % 2 != 0)
                {
                    result.Add(source[i] * source[i]);
                }
            }
            return result;
        }
    }

   
}
