using System;
using System.Collections.Generic;

namespace MonsterHunterSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Player newPlayer = new Player();

            bool playing = true;
            bool understood;

            List<Hunter> HunterTypes = new List<Hunter>();

            HunterTypes.Add(new Mage());
            HunterTypes.Add(new Rogue());
            HunterTypes.Add(new Barbarian());

            Hunter currentHunter = HunterTypes[0];

            Queue<int> powerUps = new Queue<int>();

            System.Console.WriteLine("What is your name?");
            newPlayer.username = Console.ReadLine();
            if (String.IsNullOrEmpty(newPlayer.username))
            {
                newPlayer.username = "Guild Master";
            }

            System.Console.WriteLine(newPlayer.username);
            Console.ReadLine();

            while (playing == true)
            {
                Console.Clear();
                understood = false;

                System.Console.WriteLine("What would you like to do?");
                System.Console.WriteLine("1: Go on a hunt");
                System.Console.WriteLine("2: Go to the shop");
                System.Console.WriteLine("3: Quit");

                while (understood == false)
                {
                    string answer = Console.ReadLine();

                    switch (answer)
                    {
                        case "1":
                            understood = true;

                            Console.Clear();

                            int currentPowerUp = powerUps.Dequeue();

                            System.Console.WriteLine("What level of hunt would you like to go on?");
                            System.Console.WriteLine("1: 10 XP, 15 gp");
                            System.Console.WriteLine("2: 15 XP, 25 gp");
                            System.Console.WriteLine("3: 20 XP, 35 gp");

                            bool understood2 = false;

                            System.Console.WriteLine("Which hunter would you like to send out?");
                            System.Console.WriteLine("1: Mage");
                            System.Console.WriteLine("2: Rogue");
                            System.Console.WriteLine("3: Barbarian");

                            while (understood2 == false)
                            {
                                string answer2 = Console.ReadLine();

                                switch (answer2)
                                {
                                    case "1":
                                        understood2 = true;
                                        currentHunter = HunterTypes[0];
                                        break;

                                    case "2":
                                        understood2 = true;
                                        currentHunter = HunterTypes[1];
                                        break;

                                    case "3":
                                        understood2 = true;
                                        currentHunter = HunterTypes[2];
                                        break;

                                    default:
                                        break;
                                }
                            }

                            bool understood3 = false;

                            while (understood3 == false)
                            {
                                string answer3 = Console.ReadLine();
                            
                                switch (answer3)
                                {
                                    case "1":
                                        understood3 = true;
                                        Lvl1Hunt newLvl1Hunt = new Lvl1Hunt();

                                        newLvl1Hunt.huntCombat(currentHunter.hunterHP, currentHunter.baseDMG, currentHunter.baseHitChance, currentHunter.specialAttackDMG, currentHunter.specialAttackChance, currentPowerUp);

                                        if (newLvl1Hunt.lose != true)
                                        {
                                            System.Console.WriteLine("The hunt was successful!");
                                            currentHunter.Spawn();
                                            newPlayer.XP =+ newLvl1Hunt.XP;
                                            newPlayer.money =+ newLvl1Hunt.payment;
                                        }
                                        if (newLvl1Hunt.lose == true)
                                        {
                                            System.Console.WriteLine("The hunt was unsuccesful.");
                                            currentHunter.Spawn();
                                        }
                                        break;

                                    case "2":
                                        understood3 = true;
                                        Lvl2Hunt newLvl2Hunt = new Lvl2Hunt();

                                        newLvl2Hunt.huntCombat(currentHunter.hunterHP, currentHunter.baseDMG, currentHunter.baseHitChance, currentHunter.specialAttackDMG, currentHunter.specialAttackChance, currentPowerUp);

                                        if (newLvl2Hunt.lose != true)
                                        {
                                            System.Console.WriteLine("The hunt was successful!");
                                            currentHunter.Spawn();
                                            newPlayer.XP =+ newLvl2Hunt.XP;
                                            newPlayer.money =+ newLvl2Hunt.payment;
                                        }
                                        if (newLvl2Hunt.lose == true)
                                        {
                                            System.Console.WriteLine("The hunt was unsuccesful.");
                                            currentHunter.Spawn();
                                        }
                                        break;
                                        
                                    case "3":
                                        understood3 = true;
                                        Lvl2Hunt newLvl3Hunt = new Lvl2Hunt();

                                        newLvl3Hunt.huntCombat(currentHunter.hunterHP, currentHunter.baseDMG, currentHunter.baseHitChance, currentHunter.specialAttackDMG, currentHunter.specialAttackChance, currentPowerUp);

                                        if (newLvl3Hunt.lose != true)
                                        {
                                            System.Console.WriteLine("The hunt was successful!");
                                            currentHunter.Spawn();
                                            newPlayer.XP =+ newLvl3Hunt.XP;
                                            newPlayer.money =+ newLvl3Hunt.payment;
                                        }
                                        if (newLvl3Hunt.lose == true)
                                        {
                                            System.Console.WriteLine("The hunt was unsuccesful.");
                                            currentHunter.Spawn();
                                        }
                                        break;
                                    default:
                                        understood3 = false;
                                        break;
                                }
                            }
                            Console.ReadLine();
                            break;

                        case "2":
                            understood = true;

                            break;

                        case "3":
                            understood = true;
                            playing = false;
                            System.Console.WriteLine("Farewell " + newPlayer.username);
                            Console.ReadLine();
                            break;

                        default:
                            understood = false;
                            break;
                    }
                }
            }

        }
    }
}
