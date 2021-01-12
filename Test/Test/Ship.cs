using System;

namespace Test
{
    public class Ship
    {
        Random generator = new Random();

        public int HP = 20;

        public int upgrades;

        public int cargo;

        public int DMG = 5;

        public string name = "Bob";

        public int Attack()
        {
            int dmgAmount =  generator.Next(1, DMG);
            return dmgAmount;
        }

        public void takeDMG(int dmgAmount)
        {
            HP -= dmgAmount;
        }

        public bool GetDead()
        {
            if (HP < 1)
            {
                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
