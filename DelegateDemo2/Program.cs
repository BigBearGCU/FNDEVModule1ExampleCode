﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateDemo2
{
    class Program
    {
        // Print the title of the book.
        static void PrintTitle(Book b)
        {
            Console.WriteLine("   {0}", b.Title);
        }

        // Execution starts here.
        static void Main()
        {
            BookDB bookDB = new BookDB();

            // Initialize the database with some books:
            AddBooks(bookDB);

            // Print all the titles of paperbacks:
            Console.WriteLine("Paperback Book Titles:");
            // Create a new delegate object associated with the static 
            // method Test.PrintTitle:
            bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(PrintTitle));

            // Get the average price of a paperback by using
            // a PriceTotaller object:
            PriceTotaller totaller = new PriceTotaller();
            // Create a new delegate object associated with the nonstatic 
            // method AddBookToTotal on the object totaller:
            bookDB.ProcessPaperbackBooks(new ProcessBookDelegate(totaller.AddBookToTotal));
            Console.WriteLine("Average Paperback Book Price: ${0:#.##}",
               totaller.AveragePrice());
        }

        // Initialize the book database with some test books:
        static void AddBooks(BookDB bookDB)
        {
            bookDB.AddBook("The C Programming Language",
               "Brian W. Kernighan and Dennis M. Ritchie", 19.95m, true);
            bookDB.AddBook("The Unicode Standard 2.0",
               "The Unicode Consortium", 39.95m, true);
            bookDB.AddBook("The MS-DOS Encyclopedia",
               "Ray Duncan", 129.95m, false);
            bookDB.AddBook("Dogbert's Clues for the Clueless",
               "Scott Adams", 12.00m, true);
        }

    }
}
