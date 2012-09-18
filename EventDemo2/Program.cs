using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDemo2
{
    class Program
    {
        static void Main()
        {
            Taxi t = new Taxi();
            t.FareChangeEvent += new ValueChangeEventHandler(OnValueChange);

            t.SetFare(10);

        }

        static void OnValueChange(object sender, ValueChangeEventArg args)
        {
            Console.WriteLine("old value is {0}, new value is {1}", args.getOldValue(), args.getNewValue());
        }
    }
}
