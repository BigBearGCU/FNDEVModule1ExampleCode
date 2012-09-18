using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TryFinallyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = null;
            Boolean condition = true;

            try
            {
                // run (without debugging) with condition true and with false.
                // This simulates throwing an exception that you don't
                // want to handle within a method, but want to pass up
                // the call stack to be handled by a method which calls
                // this method. 
                // Note the output which is given AFTER the UnhandledException message.
                if (condition)     // some condition which may occur
                {
                    throw new Exception("some Exception not caught here");
                }

                Console.WriteLine(data.Length);   // will throw a NullReferenceException
            }
            catch (NullReferenceException e)      // will ony catch a NullReferenceException, not an Exception 
            {
                Console.WriteLine("Caught exception: {0}", e.Message);
            }
            finally
            {
                // could be cleaning up resources here
                Console.WriteLine("In FINALLY block");
            }
            Console.WriteLine("In code after TRY-CATCH-FINALLY");
        }
    }
}
