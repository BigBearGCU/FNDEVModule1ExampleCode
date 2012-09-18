using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericMethodDemo
{
    interface IAccount
    {
        decimal Balance
        {
            get;
            set;
        } 
    }
    
    class Account : IAccount
    {
        private decimal _balance;

        public decimal Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public Account(decimal balance)
        {
            _balance = balance;
        }
    }
}
