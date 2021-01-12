using System;

namespace Pirate_Sim
{
    public class PlayerShip: Ship
    {
        public int upgrades;

        public int gold;

        public bool map;

        public void Upgrade()
        {
            DMG += 2;
        }

        public void GetStats()
        {
            System.Console.WriteLine("Your ship, " + name + ", is at " + HP + "health and has a firepower of " + DMG);
        }
    }
}
