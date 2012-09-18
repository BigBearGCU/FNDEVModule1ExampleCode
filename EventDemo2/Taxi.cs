using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDemo2
{
    class Taxi
    {
        public event ValueChangeEventHandler FareChangeEvent;

        private double fare = 0.0;

        public void SetFare(double f)
        {
            ValueChangeEventArg arg = new ValueChangeEventArg(fare, f);
            fare = f;
            FareChangeEvent(this, arg);
        }
    }
}
