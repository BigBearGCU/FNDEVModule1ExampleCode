using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace BoxingUnboxingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // BOXING
            DateTime now = DateTime.Now;  // hover cursor over DateTime to see documentation 
            Console.WriteLine("Current date and time: {0}", now);
        


            // UNBOXING
            ArrayList dates = new ArrayList();
            DateTime dt = new DateTime(2010, 1, 1);
            dates.Add(dt);   // runtime boxes DateTime to add to list

            // retrieve copy from list - runtime unboxes object to cast to DateTime variable
            DateTime copy1 = (DateTime)dates[0];  

            // modify copy
            copy1 = copy1.AddDays(1);
            Console.WriteLine("Copy1 date: {0}", copy1.ToShortDateString());

            // retrieve again - runtime unboxes object to obtain another copy
            DateTime copy2 = (DateTime)dates[0];

            // modify copy 2
            copy2 = copy2.AddMonths(1);
            Console.WriteLine("Copy2 date: {0}", copy2.ToShortDateString());

            Console.ReadKey();
        }
    }
}
