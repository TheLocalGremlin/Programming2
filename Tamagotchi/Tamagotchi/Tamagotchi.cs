using System;
using System.Collections.Generic;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        int hunger = 0;
        int boredom = 0;

        public string name;

        List<string> words = new List<string>() {" ",};

        bool isAlive = true;

        Random generator = new Random();

        public bool GetAlive()
        {
            if (isAlive == false)
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        public void Tick()
        {
            hunger ++;
            boredom ++;

            if (hunger >= 10 && boredom >= 10)
            {
                isAlive = false;
            }
        }

        public void ReduceBoredom()
        {
            boredom =- 2;
        }

        public void Feed()
        {
            System.Console.WriteLine("You give " + name + " some food.");
            System.Console.WriteLine("They look happy!");
            hunger =- 2;
        }
        public void Hi()
        {
            int n = generator.Next(words.Count);
            System.Console.WriteLine("Hello! " + words[n] + "!");

            ReduceBoredom();
        }

        public void Teach(string word)
        {
            System.Console.WriteLine("You've taught " + name + " how to say " + word + "!");
            words.Add(word);
            ReduceBoredom();
        }

        public void PrintStats()
        {
            System.Console.WriteLine("Hunger: " + hunger);
            System.Console.WriteLine("Boredom: " + boredom);

            int mood = hunger + boredom;

            if (mood <= 3)
            {
                System.Console.WriteLine(name + " is feeling very happy!");
            }

            else if (mood <=4 && mood >= 7)
            {
                System.Console.WriteLine(name + " is feeling happy!");
            }

            else if (mood <= 8 && mood >= 11)
            {
                System.Console.WriteLine(name + " is feeling neutral!");
            }

            else if (mood <= 12 && mood >= 15)
            {
                System.Console.WriteLine(name + " is feeling bad!");
            }

            else if (mood >= 16)
            {
                System.Console.WriteLine(name + " is feeling very bad!");
            }
        }
    }
}
