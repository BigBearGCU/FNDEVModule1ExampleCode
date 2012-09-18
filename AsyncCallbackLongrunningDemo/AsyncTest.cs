using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Messaging;

namespace AsyncCallbackLongrunningDemo
{
    class AsyncTest
    {
        public delegate double MathOperation(int input);

        static void Main(string[] args)
        {
            AsyncCallback callback = MyCallBackMethod;

            MathOperation op = DelegateMethod;
            op.BeginInvoke(1000000, callback, null);
            Console.WriteLine("delegate invoked");
            Console.WriteLine("continuing in main thread while calculation runs in background");
            Console.ReadLine();
        }

        // Create a method for a delegate.
        public static double DelegateMethod(int input)
        {
            double sum = 0.0;
            for (int i = 0; i < input; i++)
            {
                Random r = new Random();
                double n = r.NextDouble();
                sum += Math.Sqrt(n);
            }
            return sum;
        }

        static void MyCallBackMethod(IAsyncResult ar)
        {
            AsyncResult asyncResult = (AsyncResult)ar;
            MathOperation op = (MathOperation)asyncResult.AsyncDelegate;

            double result = op.EndInvoke(ar);
            Console.WriteLine("Result: {0}", result);
        }
    }
}
