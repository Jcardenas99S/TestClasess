using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasess.Interfaces_and_methods
{
    public class ExampleH
    {
        public void A()
        {
            using (var obj = new MyClass())
            {
                obj.DoSomething();
            }
        }

        public void B()
        {
            using var obj = new MyClass();
            obj.DoSomething();
        }

        public void C()
        {
            var obj = new MyClass();
            try
            {
                obj.DoSomething();
            }
            finally
            {
                if(obj is not null)
                {
                    ((IDisposable)obj).Dispose();
                }
            }
        }

        public void D()
        {
            var obj = new MyClass();
            obj.DoSomething();
            obj.Dispose();
        }

        public class MyClass : IDisposable
        {
            public void DoSomething() { Console.WriteLine("Disposed"); }
            public void Dispose() { Console.WriteLine("Do Something"); }
        }
    }
}
