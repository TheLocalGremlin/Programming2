using System;

namespace MonsterHunterSim
{
    public class Hunter
    {
        public int hunterHP;

        public int baseDMG;
        public int baseHitChance;
        public int specialAttackDMG;
        public int specialAttackChance;

        Random generator = new Random();

        public void takeDMG (int dmg)
        {
            hunterHP -= dmg;
        }

        public int BaseAttack()
        {
            int dmg;
            int hit = generator.Next(1, 20);
            if (hit >= baseHitChance)
            {
                dmg = generator.Next(1, baseDMG);
            }
            
            else
            {
                dmg = 0;
            }

            return dmg;
        }

        public virtual void Spawn()
        {
        }


    }
}
