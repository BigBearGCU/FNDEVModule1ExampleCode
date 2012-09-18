using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDemo
{
    public class Account
    {
        public event EventHandler<AccountEventArgs> AccountInDeficit;
        public event EventHandler<AccountEventArgs> AccountInCredit;

        private string _accountName;
        private double _balance;

        public Account(string accountName, double balance)
        {
            _accountName = accountName;
            _balance = balance;
        }

        public void Deposit(double amount)
        {
            _balance += amount;
            if (_balance > 0 && _balance <= amount)
            {
                // just moved into credit so raise the AccountInCredit event

                // create a copy of the event object
                EventHandler<AccountEventArgs> handler = AccountInCredit;
                if (handler != null)
                {
                    AccountEventArgs args = new AccountEventArgs(_balance);
                    handler(this, args);
                }
            }
        }

        public void Withdraw(double amount)
        {
            _balance -= amount;
            if (_balance < 0 && (_balance + amount) >= 0)
            {
                // just moved into deficit so raise the AccountInDeficit event

                // create a copy of the event object
                EventHandler<AccountEventArgs> handler = AccountInDeficit;
                if (handler != null)
                {
                    AccountEventArgs args = new AccountEventArgs(_balance);
                    handler(this, args);
                }
            }
        }

        public double Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }

        public string AccountName
        {
            get { return _accountName; }
            set { _accountName = value; }
        }
    }
}
