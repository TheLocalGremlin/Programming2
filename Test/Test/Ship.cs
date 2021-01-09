using System;

namespace Test
{
    public class Ship
    {
        public int HP;

        public int gold;

        public int upgrades;

        public int cargoAmount;

        public bool map;

        public void Upgrade()
        {
            System.Console.WriteLine("You have upgraded your cannons");
        }
    }
}
