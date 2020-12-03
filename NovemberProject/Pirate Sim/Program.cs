using System;

namespace Pirate_Sim
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lose = false;

            PlayerShip myShip = new PlayerShip();
            myShip.Spawn();
            System.Console.WriteLine("You are now captain of " + myShip.name);
            Console.Read();

            while (lose != true)
            {
                System.Console.WriteLine("It's a new day and you set off wherever your heart");
            
                bool alive = myShip.GetAlive();
                
            }

            void Combat()
            {
                Ship enemyShip = new Ship();
            }
        }
    }
}
