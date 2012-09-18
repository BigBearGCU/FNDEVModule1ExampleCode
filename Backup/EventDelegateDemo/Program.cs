using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDelegateDemo
{
    class Program
    {
        static private void OnMyEvent()
        {
            Console.WriteLine("This is called when the event fires.");
        }

        static public void Main()
        {
            MyClass m = new MyClass();

            m.MyEvent += OnMyEvent;
            //m.MyEvent += new MyDelegate(OnMyEvent);
            m.FireAway();
        }
    }
}
