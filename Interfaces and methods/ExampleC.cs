using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasess.Interfaces_and_methods
{
    public class ExampleC
    {
        public class Number
        {
            public int Value { get; set; }  
        }

        public void Increment(ref Number number)
        {
            number.Value++;
        }
    }
}
