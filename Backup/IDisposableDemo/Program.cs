using System;

namespace IDisposableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // object with no reference, eligible for GC
            IntPtr ip1 = new IntPtr();
            MyResource mr1 = new MyResource(1,ip1);
            Console.WriteLine("no reference to MyResource object with id = 1");
            mr1 = null;

            // explicitly calling dispose
            IntPtr ip2 = new IntPtr();
            MyResource mr2 = new MyResource(2,ip2);
            Console.WriteLine("calling Dispose on MyResource object with id = 2");
            mr2.Dispose();

            // using
            IntPtr ip3= new IntPtr();
            using(MyResource mr3 = new MyResource(3, ip3))
            {
                Console.WriteLine("in using block for MyResource object with id = 32");
            }
            Console.WriteLine("after using block for MyResource object with id = 32");

        }
    }
}
