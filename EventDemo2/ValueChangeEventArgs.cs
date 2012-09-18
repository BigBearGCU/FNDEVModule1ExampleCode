using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDemo2
{
    public delegate void ValueChangeEventHandler(object sender, ValueChangeEventArg args);

    public class ValueChangeEventArg : EventArgs
    {
        private object oldValue;
        private object newValue;

        public ValueChangeEventArg(object ov, object nv)
        {
            oldValue = ov;
            newValue = nv;
        }

        public object getOldValue() { return oldValue; }
        public object getNewValue() { return newValue; }
    }
}
