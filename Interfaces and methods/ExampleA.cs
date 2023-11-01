using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasess.Interfaces_and_methods
{
    public class ExampleA
    {
        public class A
        {
            public A() { Console.Write("1"); }
        }
        public class B : A
        {
            public B() { new A(); Console.Write("2"); }
        }
        public class C : B
        {
            public C() { new B(); Console.Write("3"); }
        }
       
        
    }
}

