using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            // create an array of strings
            string[] myFriends = {"Claire","Hayley","Sarah"};

            // invoke generic method: implicit type parameter
            MyAlgorithms.DisplayArray(myFriends);

            // invoke generic method: explicit type parameter
            MyAlgorithms.DisplayArray<string>(myFriends);


            // create an array of Account objects
            Account[] accounts = new Account[3];
            accounts[0] = new Account(10.0m);
            accounts[1] = new Account(20.0m);
            accounts[2] = new Account(30.0m);

            // invoke generic method
            decimal amount = MyAlgorithms.Accumulate(accounts);
            Console.WriteLine("{0:c}", amount);
        }
    }
}
