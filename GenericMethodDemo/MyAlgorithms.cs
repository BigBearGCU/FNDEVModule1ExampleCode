using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericMethodDemo
{
    class MyAlgorithms
    {
        public static void DisplayArray<T>(T[] Array)
        {
            foreach (T item in Array)
            {
                Console.WriteLine("{0}", item);
            }
        }

        public static decimal Accumulate<TAccount>(IEnumerable<TAccount> coll)
            where TAccount : IAccount
        {
            decimal sum = 0;
            foreach (TAccount obj in coll)
            {
                sum += obj.Balance;
            }
            return sum;
        }
    }
}
