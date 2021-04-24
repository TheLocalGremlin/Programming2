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

                string answer = Console.ReadLine();

                while (understood == false)
                {
                    switch (answer)
                    {
                        case "1":
                            understood = true;
                            
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
