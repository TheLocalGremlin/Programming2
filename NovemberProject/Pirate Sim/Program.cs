using System;
using System.Collections.Generic;

namespace Pirate_Sim
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lose = false;

            Random generator = new Random();


            PlayerShip myShip = new PlayerShip();
            myShip.Spawn();
            myShip.upgrades = 0;
            System.Console.WriteLine("You are now captain of " + myShip.name);
            Console.Read();

            while (lose != true)
            {
                System.Console.WriteLine("It's a new day and you set off wherever your heart desires.");
                System.Console.WriteLine("What would you like to do?");
                System.Console.WriteLine("1: See where the day takes you.");
                System.Console.WriteLine("2: ");



            
                bool alive = myShip.GetAlive();
            }

            void Combat()
            {
                Ship enemyShip = new Ship();

            }

            void RandomEvent()
            {
                

                List<string> events = new List<string>()
                {
                    
                };

            }
        }
    }
}
