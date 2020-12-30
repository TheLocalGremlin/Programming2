using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
           Person player = new Person();

           player.Spawn();

           Console.Read();
        }
    }
}
