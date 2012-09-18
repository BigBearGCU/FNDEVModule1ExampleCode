using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting.Messaging;

namespace AsyncCallbackDemo
{
    class AsyncTest
    {
        public delegate double MathOperation(double input);

        static void Main(string[] args)
        {
            AsyncCallback callback = MyCallBackMethod;

            MathOperation op = Math.Sin;
            //last parameter, state information
            op.BeginInvoke(Math.PI / 2, callback, "name");
            Console.WriteLine("delegate invoked");
            Console.ReadLine();
        }

        static void MyCallBackMethod(IAsyncResult ar)
        {
            AsyncResult asyncResult = (AsyncResult)ar;
            string name = (string)ar.AsyncState;
            MathOperation op = (MathOperation)asyncResult.AsyncDelegate;

            double result = op.EndInvoke(ar);
            Console.WriteLine("Result: {0}", result);
        }
    }
}
