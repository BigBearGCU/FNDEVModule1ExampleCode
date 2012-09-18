using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CombiningDelegatesDemo
{
    // Compiler will create a multicast delegate class, i.e a class which is a
    // subclass of System.MulticastDelegate. This example has a void return type,
    // which is usually the case when combining delegates (e.g. events)
    // but a multicast delegate with a specific return type can return 
    // values from each individual delegate by accessing its invocation list.
    // Apparently earlier versions of framework compiler would create subclass of 
    // MulticastDelegate if delegate return type is void, subclass of Delegate (single cast
    // otherwise (see 1.1 documentation of MulticastDelegate class)
    delegate void Del(string s);

    class Program
    {
        static void Hello(string s)
        {
            System.Console.WriteLine("  Hello, {0}!", s);
        }

        static void Goodbye(string s)
        {
            System.Console.WriteLine("  Goodbye, {0}!", s);
        }


        static void Main()
        {
            Del a, b, c, d, e, f;

            // Create the delegate object a that references 
            // the method Hello:
            a = Hello;

            // Create the delegate object b that references 
            // the method Goodbye:
            b = Goodbye;

            // The two delegates, a and b, are composed to form c: 
            c = a + b;

            // The two delegates, b and a, are composed to form d: 
            d = b + a;

            // Remove a from the composed delegate, leaving e, 
            // which calls only the method Goodbye:
            e = c - a;

            // Use Delegate.Combine
            f = (Del)Delegate.Combine(a, b);

            System.Console.WriteLine("Invoking delegate a:");
            a("A");
            System.Console.WriteLine("Invoking delegate b:");
            b("B");
            System.Console.WriteLine("Invoking delegate c:");
            c("C");
            System.Console.WriteLine("Invoking delegate d:");
            d("D");
            System.Console.WriteLine("Invoking delegate e:");
            e("E");
            System.Console.WriteLine("Invoking delegate f:");
            f("F");

            // Determine whether a delegate is subclass of System.Multicast
            if (a is System.MulticastDelegate) 
            {
                Console.WriteLine("a is System.MulticastDelegate");
            }

            // Get number of delegates in the invocation list of a delegate
            Delegate[] DelegateList;
            DelegateList = d.GetInvocationList();
            Console.WriteLine("d contains " + DelegateList.Length + " delegate(s).");
        }
    }
}
