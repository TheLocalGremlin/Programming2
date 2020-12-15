using System;

namespace Pirate_Sim
{
    public class PlayerShip: Ship
    {
        public int upgrades;

        public bool map;

         public void Repair()
        {
            int healAmount = 25 - HP;
            HP += healAmount;
        }

        public void Upgrade()
        {
            DMG =+ 2;
        }

        public void GetStats()
        {
            System.Console.WriteLine("Your ship, " + name + ", is at " + HP + "health and has a firepower of " + DMG);
        }
    }
}
