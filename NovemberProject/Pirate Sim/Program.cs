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
            myShip.cargo = 5;
            System.Console.WriteLine("You are now captain of " + myShip.name);
            Console.Read();

            while (lose != true)
            {
                Console.Clear();
                System.Console.WriteLine("It's a new day and you set off wherever your heart desires.");
                Console.ReadLine();
                System.Console.WriteLine("Morning:");
                RandomEvent();
                bool dead = myShip.GetDead();
                if (dead == true)
                {
                    lose = true;
                    break;
                }

                Console.Clear();
                System.Console.WriteLine("Afternoon:");
                RandomEvent();
                dead = myShip.GetDead();
                if (dead == true)
                {
                    lose = true;
                    break;
                }

                Console.Clear();
                System.Console.WriteLine("Evening:");
                RandomEvent();
                dead = myShip.GetDead();
                if (dead == true)
                {
                    lose = true;
                    break;
                }
                
            }

            Console.Clear();
            System.Console.WriteLine("You have died.");
            System.Console.WriteLine("You finished with " + myShip.gold + " gp");
            Console.ReadLine();

            void Combat()
            {
                Ship enemyShip = new Ship();

                bool combat = true;
                bool dead = false;

                bool enemyDefense = false;
                bool playerDefense = false;


                while (combat == true)
                {
                    Console.Clear();
                    understood = false;
                    while (understood == false)
                    {
                        System.Console.WriteLine("What would you like to do?");
                        System.Console.WriteLine("1: Shoot");
                        System.Console.WriteLine("2: Dodge");
                        System.Console.WriteLine("3: Attempt Escape (1/4 chance of success)");

                        string answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "1":
                                understood = true;
                                System.Console.WriteLine("At your mark, the master gunner orders all of the cannoneers to take aim.");

                                int hit = generator.Next(1, 20);
                                System.Console.WriteLine(hit);

                                if (hit > 5 && enemyDefense == false)
                                {
                                    System.Console.WriteLine("The cannons fire with a thunderous crack and the cannonballs manage to hit the other ship.");
                                    int dmg = myShip.Attack();
                                    enemyShip.takeDMG(dmg);
                                    System.Console.WriteLine(dmg);
                                }

                                else if (hit > 10 && enemyDefense == true)
                                {
                                    System.Console.WriteLine("The cannons fire with a thunderous crack and the cannonballs manage to hit the other ship.");
                                    int dmg = myShip.Attack();
                                    enemyShip.takeDMG(dmg);
                                    System.Console.WriteLine(dmg);
                                }

                                else
                                {
                                    System.Console.WriteLine("The cannons fire with a thunderous crack but you unfortunately manage to hit nothing.");
                                }
                                break;

                            case "2":
                                understood = true;
                                playerDefense = true;
                                System.Console.WriteLine("You order your helmsman to be ready for any upcoming attacks.");
                                break;

                            case "3":
                            understood = true;
                                System.Console.WriteLine("Assesing the situation, you decide it might be best to flee.");
                                int escapeAttempt = generator.Next(1, 20);

                                if (escapeAttempt > 15)
                                {
                                    System.Console.WriteLine("You try and escape but you are unable.");
                                }

                                else
                                {
                                    System.Console.WriteLine(enemyShip.name + " tries to give chase but eventually you manage to escape.");
                                    combat = false;
                                }
                                break;

                            default:
                                break;
                        }

                        System.Console.WriteLine("Your HP: " + myShip.HP);
                        System.Console.WriteLine("Enemy's HP: " + enemyShip.HP);
                        Console.ReadLine();
                    }
                    enemyDefense = false;
                    if (combat == false)
                    {
                        break;
                    }

                    dead = enemyShip.GetDead();
                    if (dead == true)
                    {
                        break;
                    }

                    Console.Clear();

                    int enemyTurn = generator.Next(1, 100);

                    if (enemyTurn > 0 && enemyTurn < 50)
                    {
                        int hit = generator.Next(1, 20);
                        System.Console.WriteLine(hit);

                        if (hit > 5 && playerDefense == false)
                        {
                            System.Console.WriteLine(enemyShip.name + "'s cannons fire with a thunderous crack and the cannonballs manage to hit you.");
                            int dmg = enemyShip.Attack();
                            myShip.takeDMG(dmg);
                            System.Console.WriteLine(dmg);
                        }

                        else if (hit > 10 && playerDefense == true)
                        {
                            System.Console.WriteLine(enemyShip.name + "'s cannons fire with a thunderous crack and the cannonballs manage to hit you.");
                            int dmg = enemyShip.Attack();
                            myShip.takeDMG(dmg);
                            System.Console.WriteLine(dmg);
                        }

                        else
                        {
                            System.Console.WriteLine(enemyShip + "'s cannons fire with a thunderous crack but you unfortunately manage to hit nothing.");
                        }
                    }

                    if (enemyTurn >= 50 && enemyTurn < 80)
                    {
                        System.Console.WriteLine("You can hear the barked orders of " + enemyShip.name + "'s captain.");
                        System.Console.WriteLine("You can vaguely make out them telling their crew to get ready for any attacks.");
                        enemyDefense = true;
                    }

                    if (enemyTurn >= 80)
                    {
                        System.Console.WriteLine("You can hear the barked orders of " + enemyShip.name + "'s captain.");
                        System.Console.WriteLine("You can vaguely make out them telling their crew to haul ass.");

                        int escapeAttempt = generator.Next(1, 20);

                        if (escapeAttempt > 15)
                        {
                            System.Console.WriteLine(enemyShip.name + " tries to escape but they are unable.");
                        }

                        else
                        {
                            System.Console.WriteLine("You try to give chase but eventually they manage to escape.");
                            combat = false;
                        }
                    }

                    playerDefense = false;

                    System.Console.WriteLine("Your HP: " + myShip.HP);
                    System.Console.WriteLine("Enemy's HP: " + enemyShip.HP);
                    dead = myShip.GetDead();
                    if (dead == true)
                    {
                        break;
                    }
                    Console.ReadLine();
                }

                Console.Clear();

                if (enemyShip.HP < 1)
                {
                    System.Console.WriteLine("As " + enemyShip.name + " sinks below the waves, your crew manages to salvage its cargo.");
                    System.Console.WriteLine("You leave the battle " + enemyShip.cargo + " units of cargo richer.");
                }
                
            }

            void RandomEvent()
            {
                int randEv = generator.Next(1, 100);

                System.Console.WriteLine(randEv);

                understood = false;

                if (randEv > 0 && randEv <= 30)
                {
                    System.Console.WriteLine("While you and your crew sail along one of your crewmates calls for you, pointing off the side of the ship.");
                    System.Console.WriteLine("'Looks like another ship Captain! Do you want to go on the offensive?'");
                    Console.ReadLine();
                    while (understood == false)
                    {
                        Console.Clear();
                        System.Console.WriteLine("What would you like to do?");
                        System.Console.WriteLine("1: Attack");
                        System.Console.WriteLine("2: Leave the ship alone");

                        string answer = Console.ReadLine();

                        switch (answer)
                        {
                            case "1":
                                understood = true;
                                System.Console.WriteLine("'You heard the Captain! Full sail towards the ship!'");
                                Console.ReadLine();
                                Combat();
                                break;

                            case "2":
                                understood = true;
                                System.Console.WriteLine("'As you wish Captain, continue on!'");
                                Console.ReadLine();
                                break;

                            default:
                                break;
                        }
                    }
                }

                if (randEv > 30 && randEv <= 40)
                {
                    System.Console.WriteLine("While you and your crew sail along one of your crewmates calls for you, pointing off the side of the ship.");
                    System.Console.WriteLine("'Captain! Look!'");
                    System.Console.WriteLine("Another ship is barrelling towards yours at a speed you don't think you'll be able to outrun currently.");
                    System.Console.WriteLine("You hear the ringing of a bell as your crew ready themselves for combat.");
                    Console.ReadLine();
                    Combat();
                }

                if (randEv > 40 && randEv <= 50)
                {
                    System.Console.WriteLine("A storm picks up overhead and your crew scrambles frantically to prepare the ship for the incoming harshness.");
                    int stormDamage = generator.Next(2, 8);
                    System.Console.WriteLine("You manage to get through the storm and your ship takes " + stormDamage + " damage.");
                    myShip.takeDMG(stormDamage);
                    System.Console.WriteLine("You are now at " + myShip.HP + " health.");
                    Console.ReadLine();    
                }

                if (randEv > 50 && randEv <= 80)
                {
                    System.Console.WriteLine("You see a port town in the distance and decide to take a rest from sea.");
                    Console.ReadLine();
                    Store();
                }

                if (randEv > 80)
                {
                    if (randEv < 80 && randEv >= 90 && myShip.map == true)
                    {
                        System.Console.WriteLine("Nothing of note happens.");
                        Console.ReadLine();
                    }

                    if (myShip.map == true && randEv >= 90)
                    {
                        System.Console.WriteLine("You see an island in the distance, you're about to change course but something feels familiar about it.");
                        System.Console.WriteLine("Then you remember the map you bought and realize the similarities in the geography.");
                        System.Console.WriteLine("You order your crew to dock and take a small group and one of the dinghys and make your way to the island.");
                        System.Console.WriteLine("It takes several hours but you and your crew end up finding the location of the buried treasure and digging it up.");
                        int treasureAmount = generator.Next(25, 50);
                        System.Console.WriteLine("You leave the island " + treasureAmount + " gold pieces richer.");
                        myShip.gold += treasureAmount;
                        Console.ReadLine();
                    }

                    if (myShip.map == false && randEv > 80)
                    {
                        System.Console.WriteLine("Nothing of note happens.");
                        Console.ReadLine();
                    }
                }
                
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

                            if (newPort.mapSold == true && myShip.map == false)
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
