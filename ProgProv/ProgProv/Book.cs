using System;
using System.Collections.Generic;

namespace ProgProv
{
    public class Book
    {
        public int price;
        int rarity;
        int actualValue;
        int chance;

        string name;
        string category;

        List<string> titles = new List<string>()
        {
            "The Dream Dawn", "The Necronomicon", "Ideas on Children of the Sky: Magnificent Creatures",
            "Interviews with some Vampires", "Fairefire 451", "Great Divinations",
            "The Summoning of Dragons", "Die Waldhexe und andere Zemnische Volksmärchen", "Tusk Love",
            "The Courting of the Crick", "Change and the Potentials of Transmutability"
        };

        List<string> genres = new List<string>()
        {
            "Biographgy", "Science Fiction", "Romance", "Assorted Short Stories",
            "Fairytale", "Fantasy", "Fact", "Realistic Fiction"
        };

        bool cursed;

        Random generator = new Random();

        public void Spawn()
        {
            rarity = generator.Next(1,5);
            actualValue = generator.Next(5, 50);

            chance = generator.Next(1,10);

            if (chance < 7)
            {
                cursed = false;
            }

            else
            {
                cursed = true;
            }

            int t = generator.Next(titles.Count);
            name = titles[t];

            int g = generator.Next(genres.Count);
            category = genres[g];
        }

        public void PrintInfo()
        {
            System.Console.WriteLine("Name: " + name);
            System.Console.WriteLine("Category: " +category);
            System.Console.WriteLine("Rarity: " + rarity);
            System.Console.WriteLine("Price: " + actualValue);
        }
    }
}
