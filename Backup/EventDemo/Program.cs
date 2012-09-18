using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account("Jane", 30);
            acc1.AccountInCredit += new EventHandler<AccountEventArgs>(acc1_AccountInCredit);
            //acc1.AccountInCredit += OnAccountInCredit;
            //acc1.AccountInDeficit += OnAccountInDeficit;

            acc1.Withdraw(100);
            acc1.Deposit(50);
            acc1.Deposit(70);
        }

        static void acc1_AccountInCredit(object sender, AccountEventArgs e)
        {
            Console.WriteLine("Account in Cred");
            Console.ReadKey();
        }

        static void OnAccountInCredit(object sender, AccountEventArgs args)
        {
            double balance = args.Balance;
            Console.WriteLine("Account in credit, new balance: {0:c}", balance);
        }

        static void OnAccountInDeficit(object sender, AccountEventArgs args)
        {
            double balance = args.Balance;
            Console.WriteLine("Account in deficit, new balance: {0:c}", balance);
        }
    }
}
