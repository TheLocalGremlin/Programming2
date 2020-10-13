using System;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool alive = true;
            bool understood = false;

            string answer;

            Tamagotchi newTamagotchi = new Tamagotchi();

            Console.WriteLine("Name your tomagatchi:");
            newTamagotchi.name = Console.ReadLine();

            while (alive == true)
            {
                Console.Clear();

                understood = false;

                newTamagotchi.Tick();

                alive = newTamagotchi.GetAlive();

                System.Console.WriteLine("What would you like to do?");
                System.Console.WriteLine("1: Say hi to your tamagotchi");
                System.Console.WriteLine("2: See your tamagotchi's stats");
                System.Console.WriteLine("3: Feed your tamagotchi");
                System.Console.WriteLine("4: Teach your tamagotchi a new word");
                System.Console.WriteLine("5: Nothing");

                while (understood == false)
                {
                    answer = Console.ReadLine();

                    switch(answer.ToLower())
                    {
                        case "1":
                            understood = true;
                            newTamagotchi.Hi();
                            break;

                        case "2":
                            understood = true;
                            newTamagotchi.PrintStats();
                            break;

                        case "3":
                            understood = true;
                            newTamagotchi.Feed();
                            break;

                        case "4":
                            understood = true;
                            System.Console.WriteLine("What word would you like to teach " + newTamagotchi.name + "?");
                            string word = Console.ReadLine();
                            newTamagotchi.Teach(word);
                            break;

                        case "5":
                            understood = true;
                            break;

                        default:
                            System.Console.WriteLine("Sorry, I didn't understand that.");
                            break;
                    }

                    Console.ReadLine();
                }
            }

            System.Console.WriteLine(newTamagotchi.name + " has died.");
            Console.ReadLine();
        }
    }
}
