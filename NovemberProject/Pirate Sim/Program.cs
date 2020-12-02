using System;

namespace Pirate_Sim
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lose = false;

            Ship myShip = new Ship();

            while (lose != true)
            {
                bool alive = myShip.GetAlive();

                System.Console.WriteLine("It's a new day and you set off wherever your heart");
            }
        }
    }
}
