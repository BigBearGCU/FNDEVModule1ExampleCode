using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDemo
{
    class Program
    {
        public delegate void Del(string message);

        static void Main(string[] args)
        {
            // Instantiate the delegate.
            Del handler = new Del(DelegateMethod);
            //or
            //Del handler = DelegateMethod;
            handler("Hello");
            // Call the delegate.
            //handler("Hello World");

            // Invoke method which uses delegate as callback
            MethodWithCallback(1, 2, handler);
        }

        // Create a method for a delegate.
        public static void DelegateMethod(string message)
        {
            System.Console.WriteLine(message);
        }

        // Method which uses a delegate as a callback
        public static void MethodWithCallback(int param1, int param2, Del callback)
        {
            callback("The number is: " + (param1 + param2).ToString());
        }
    }
}
