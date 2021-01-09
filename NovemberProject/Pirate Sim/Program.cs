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

                Store();

                Console.ReadLine();

                Store();
                
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
                Port newPort = new Port();
                newPort.Spawn();
                finished = false;
                understood = false;

                while (finished == false || understood == false)
                {
                    understood = false;
                    Console.Clear();
                    System.Console.WriteLine("Welcome to " + newPort.name);
                    System.Console.WriteLine("What would you like to do?");
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

                            if (myShip.upgrades >= 5)
                            {
                                System.Console.WriteLine("You cannot upgrade your ship farther.");
                            }

                            else if (myShip.gold < upgradePrice)
                            {
                                System.Console.WriteLine("You don't have the funds for this upgrade");
                            }

                            else
                            {
                                bool validAnswer = false;

                                while (validAnswer == false)
                                {
                                    System.Console.WriteLine("The upgrade will cost " + upgradePrice + " gold pieces");
                                    System.Console.WriteLine("Would you like to upgrade your cannons?");
                                    System.Console.WriteLine("1: Yes");
                                    System.Console.WriteLine("2: No");

                                    string upgradeBuyAnswer = Console.ReadLine();

                                    switch (upgradeBuyAnswer)
                                    {
                                        case "1":
                                            validAnswer = true;
                                            myShip.upgrades ++;
                                            myShip.gold -= upgradePrice;
                                            myShip.Upgrade();
                                            System.Console.WriteLine("You now have " + myShip.gold + " gp.");
                                        break;

                                        case "2":
                                            validAnswer = true;
                                        System.Console.WriteLine("Alright then");
                                        break;

                                        default:
                                        break;
                                        
                                    }
                                    
                                }
                            }
                            Console.Read();
                        break;

                        case "2":
                            understood = true;
                            int difference  = 25 - myShip.HP;
                            int repairPrice = difference * 2;
                            

                            if (difference < 1)
                            {
                                System.Console.WriteLine("You are already at full health");
                            }

                            else
                            {
                                System.Console.WriteLine("Repairs cost " + repairPrice + " gold pieces");

                                if (myShip.gold < repairPrice)
                                {
                                    System.Console.WriteLine("You don't have the funds for these repairs");
                                }

                                else
                                {
                                    myShip.HP =+ difference;
                                    System.Console.WriteLine("You now have " + myShip.gold + " gp.");
                                    System.Console.WriteLine(myShip.HP);
                                }
                            }
                            Console.Read();
                        break;

                        case "3":
                            understood = true;

                            if (myShip.cargo < 1)
                            {
                                System.Console.WriteLine("You don't have any cargo to sell");
                            }

                            else
                            {
                                System.Console.WriteLine("The price of cargo in this port is " + newPort.cargoValue + " gold pieces per unit and you have " + myShip.cargo + " units of cargo");

                                int cargoPrice = newPort.cargoValue * myShip.cargo;

                                bool validAnswer = false;

                                while (validAnswer == false)
                                {
                                    System.Console.WriteLine("Would you like to sell your cargo?");
                                    System.Console.WriteLine("1: Yes");
                                    System.Console.WriteLine("2: No");

                                    string cargoSellAnswer = Console.ReadLine();

                                    switch (cargoSellAnswer)
                                    {
                                        case "1":
                                            validAnswer = true;
                                            System.Console.WriteLine("You sell your cargo for " + cargoPrice + " gold pieces");
                                            myShip.cargo = 0;
                                            myShip.gold += cargoPrice;
                                            System.Console.WriteLine("You now have " + myShip.gold + " gp.");
                                        break;

                                        case "2":
                                            validAnswer = true;
                                            System.Console.WriteLine("Alright then");
                                        break;

                                        default:
                                        break;
                                    }

                                }
                                
                            }
                            Console.Read();
                        break;

                        case "4":
                            understood = true;
                            finished = true;

                            if (newPort.mapSold == true)
                            {
                                System.Console.WriteLine("Before you leave, the shopkeeper stops you.");
                                System.Console.WriteLine("'May I interest you in another item?'");
                                System.Console.WriteLine("The shopkeeper pulls out a small box from a shelf.");
                                System.Console.WriteLine("Inside the box is a scroll of fine parchment.");
                                System.Console.WriteLine("'This,' they explain, 'is a map that belonged to a famous pirate!'");
                                System.Console.WriteLine("'Now, this pirate died a long time ago but some say that their stash of treasure is still buried somewhere around these islands.'");
                                Console.ReadLine();
                                System.Console.Write("'This map could be yours for only 30 gp, ");

                                if (myShip.gold < 30)
                                {
                                    System.Console.WriteLine("but unfortunately it seems that you have insufficient funds for it.'");
                                    System.Console.WriteLine("'Perhaps next time.'");
                                }

                                else
                                {
                                    System.Console.WriteLine("so what do you say?");
                                    understood = false;

                                    while (understood == false)
                                    {
                                        System.Console.WriteLine("1: I'll take it.");
                                        System.Console.WriteLine("2: No thanks.");

                                        string mapAnswer = Console.ReadLine();

                                        switch (mapAnswer)
                                        {
                                            case "1":
                                            understood = true;
                                                System.Console.WriteLine("'Good choice.'");
                                                System.Console.WriteLine("You now own a treasure map.");
                                                myShip.map = true;
                                                break;

                                            case "2":
                                                understood = true;
                                                System.Console.WriteLine("Alright, suit yourself.");
                                                break;

                                            default:
                                                break;
                                        }
                                    }
                                }
                            }
                            System.Console.WriteLine("You have left the store");
                            Console.Read();
                        break;

                        default:
                            
                        break;
                    }
                }
            }
        }
    }
}
