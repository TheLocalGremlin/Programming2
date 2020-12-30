using System;
using System.Collections.Generic;

namespace Pirate_Sim
{
    class Program
    {
        static void Main(string[] args)
        {
            bool lose = false;
            bool finished = false;
            bool understood = false;

            Random generator = new Random();


            PlayerShip myShip = new PlayerShip();
            myShip.Spawn();
            myShip.upgrades = 0;
            myShip.gold = 10;
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

            void Store()
            {
                Console.Clear();
                finished = true;
                understood = false;
                System.Console.WriteLine("What would you like to do?");
                while (finished == false && understood == false)
                {
                    System.Console.WriteLine("1: Upgrade your cannons");
                    System.Console.WriteLine("2: Repair your ship");
                    System.Console.WriteLine("3: Sell some cargo");
                    System.Console.WriteLine("4: Leave the store");

                    string answer = Console.ReadLine();
                    switch (answer)
                    {
                        case "1":
                            understood = true;
                            int upgradePrice = 10 + (5 * myShip.upgrades);

                            if (myShip.upgrades <= 5)
                            {
                                System.Console.WriteLine("You cannot upgrade your ship farther.");
                            }

                            else if (myShip.gold < upgradePrice)
                            {
                                System.Console.WriteLine("You don't have the funds for this upgrade");
                            }

                            else
                            {
                                myShip.upgrades ++;
                                myShip.Upgrade();
                            }
                            break;

                            case "2":
                                int difference  = 25 - myShip.HP;
                                int repairPrice = difference * 2;

                                if (difference < 1)
                                {
                                    System.Console.WriteLine("You are already at full health");
                                }

                                else if (myShip.gold < repairPrice)
                                {
                                    System.Console.WriteLine("You ");
                                }
                                break;
                    }
                }
            }
        }
    }
}
