using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDemo
{
    public class AccountEventArgs : EventArgs
    {
        private double _balance;

        public AccountEventArgs(double b)
        {
            _balance = b;
        }

        public double Balance
        {
            get { return _balance; }
        }
    }
}
