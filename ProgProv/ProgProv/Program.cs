using System;

namespace ProgProv
{
    class Program
    {
        static void Main(string[] args)
        {
            Book newBook = new Book();

            newBook.Spawn();

            newBook.PrintInfo();
            Console.ReadLine();
        }
    }
}
