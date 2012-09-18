using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace AsyncThreadDemo
{
    public delegate string AsyncMethodCaller(int callDuration, out int threadId);

    class Program
    {
        static void Main(string[] args)
        {
            // The asynchronous method puts the thread id here.
            int threadId;

            // Create the delegate.
            AsyncMethodCaller caller = new AsyncMethodCaller(TestMethod);

            // Initiate the asychronous call.
            IAsyncResult result = caller.BeginInvoke(3000,
                out threadId, null, null);

            //Thread.Sleep(0);
            Console.WriteLine("Main thread {0} does some work.",
                Thread.CurrentThread.ManagedThreadId);

            // Wait for the WaitHandle to become signaled.
            result.AsyncWaitHandle.WaitOne();

            // Call EndInvoke to retrieve the results.
            string returnValue = caller.EndInvoke(out threadId, result);

            // Close the wait handle.
            result.AsyncWaitHandle.Close();

            Console.WriteLine("The call executed on thread {0}, with return value \"{1}\".",
                threadId, returnValue);

        }

        static string TestMethod(int callDuration, out int threadId)
        {
            Console.WriteLine("Test method begins.");
            Thread.Sleep(callDuration);
            threadId = Thread.CurrentThread.ManagedThreadId;
            return String.Format("My call time was {0}.", callDuration.ToString());
        }

    }
}
