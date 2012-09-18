using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IComparableDemo
{
    class Currency : IComparable<Currency>
    {
        private int _dollars, _cents;

        public Currency(int dollars, int cents)
        {
            _dollars = dollars;
            _cents = cents;
        }

        public int Dollars
        {
            get { return _dollars; }
            set { _dollars = value; }
        }

        public int Cents
        {
            get { return _cents; }
            set { _cents = value; }
        }

        public int CompareTo(Currency other)
        {
            int thisValue = (this._dollars * 100) + this._cents;
            int otherValue = (other._dollars * 100) + other._cents;
            return thisValue.CompareTo(otherValue);
        }
    }
}
