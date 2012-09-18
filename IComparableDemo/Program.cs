using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComparableDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // DEMO: modify Currency to implement IComparable or not

            Currency[] salaries = {new Currency(100,0),
                                      new Currency(57,23),
                                      new Currency(250,97)};
            Array.Sort(salaries);
            foreach (Currency curr in salaries)
            {
                Console.WriteLine("Salary: ${0}.{1}", curr.Dollars, curr.Cents);
            }
            Console.ReadKey();
        }
    }
}
