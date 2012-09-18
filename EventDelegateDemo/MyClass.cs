using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDelegateDemo
{
    public delegate void MyDelegate();   // delegate declaration

    class MyClass
    {
        //public delegate void MyDelegate();   // delegate declaration
        public event MyDelegate MyEvent;

        public void FireAway()
        {
            if (MyEvent != null)
                MyEvent();
        }
    }
}
