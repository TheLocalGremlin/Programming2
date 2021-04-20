using System;

namespace MonsterHunterSim
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            System.Console.WriteLine("What is your name?");
            player.username = Console.ReadLine();
            if (String.IsNullOrEmpty(player.username))
            {
                player.username = "Guild Master";
            }

            Console.ReadLine();

            //while
        }
    }
}
