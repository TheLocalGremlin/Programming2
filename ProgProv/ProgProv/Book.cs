using System;

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

        bool cursed;

        Random generator = new Random();

        public Book()
        {
            rarity = generator.Next(1,5);
            actualValue = generator.Next(5, 50);

            chance = generator
        }
    }
}
