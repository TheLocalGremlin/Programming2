using System;

namespace ProgProv
{
    public class Customers
    {
        public int amount;

        bool haggle;

        Random generator = new Random();

        public void Spawn()
        {
            amount = generator.Next(5);

            int p = generator.Next(1, 10);

            if (p < 7)
            {
                haggle = true;
            }
        }
    }
}
