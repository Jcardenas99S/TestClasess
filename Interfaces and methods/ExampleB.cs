using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasess.Interfaces_and_methods
{
    public class ExampleB
    {
        public class aA
        {
            public aA() { this.Foo(); Console.Write("A"); }
            public virtual void Foo() => Console.Write("1");
        }
        public class bB : aA
        {
            public bB() { Console.Write("B"); this.Foo(); }
            public override void Foo() => Console.Write("2");
        }
        public class cC : bB
        {
            public cC() { this.Foo(); Console.Write("C"); }
            public override void Foo() => Console.Write("3");
        }

    }
}
