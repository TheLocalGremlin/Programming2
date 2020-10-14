using System;

namespace ProgProv
{
    class Program
    {
        static void Main(string[] args)
        {
            Book newBook = new Book();

            Customers newCustomers = new Customers();

            newBook.Spawn();
            newCustomers.Spawn();
            
            System.Console.WriteLine("You have " + newCustomers.amount + " customers.");
        }
    }
}
