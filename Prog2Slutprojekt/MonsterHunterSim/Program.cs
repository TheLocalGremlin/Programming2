using System;

namespace MonsterHunterSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            bool playing = true;
            bool understood;

            System.Console.WriteLine("What is your name?");
            player.username = Console.ReadLine();
            if (String.IsNullOrEmpty(player.username))
            {
                player.username = "Guild Master";
            }

            System.Console.WriteLine(player.username);
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
                            System.Console.WriteLine("What level of hunt would you like to go on?");
                            System.Console.WriteLine("1: 10 XP, 15 gp");
                            System.Console.WriteLine("2: 15 XP, 25 gp");
                            System.Console.WriteLine("3: 20 XP, 35 gp");

                            bool understood2 = false;

                            while (understood2 == false)
                            {
                                string answer2 = Console.ReadLine();
                            
                                switch (answer2)
                                {
                                    case "1":
                                        understood2 = true;
                                        Lvl1Hunt newHunt = new Lvl1Hunt();
                                        break;

                                    default:
                                        understood2 = false;
                                        break;
                                }
                            }
                            break;

                        case "2":
                            understood = true;
                            break;

                        case "3":
                            understood = true;
                            playing = false;
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
