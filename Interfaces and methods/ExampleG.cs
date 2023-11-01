using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestClasess.Interfaces_and_methods
{
    public class ExampleG
    {
        public void A() {
            var foo = new Foo();
            using (foo)
            {
                foo.Baz();
            }
            foo.Bar();
        }

        public void B()
        {
            using (var foo = new Foo())
            {
                foo.Baz();
                foo.Bar();
            }
        }

        public void C()
        {
            using var foo = new Foo();
            foo.Baz();
            foo.Bar();
        }

        public void D()
        {
            var foo = new Foo();

            try
            {
                foo.Baz();
            }
            finally
            {
                foo.Dispose();  
            }
            foo.Bar();
        }

        public sealed class Foo: IDisposable 
        {
            private bool disposed;

            public void Bar()
            {
                if (disposed)
                {
                    throw new ObjectDisposedException(nameof(Foo));
                }
                Console.Write("Bar.");
            } 
            public void Baz()
            {
                if (disposed)
                {
                    throw new ObjectDisposedException(nameof(Foo));
                }
                Console.Write("Baz.");
            }

            public void Dispose() => disposed = true;
        }
    }
}
