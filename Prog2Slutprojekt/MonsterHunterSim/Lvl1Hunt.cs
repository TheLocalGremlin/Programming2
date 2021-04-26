using System;

namespace MonsterHunterSim
{
    public class Lvl1Hunt: Hunt
    {
        public Lvl1Hunt()
        {
            XP = 10;
            payment = 15;
            difficulty = 1;

            monsterDMG = 2;
            monsterHitChance = 10;
        }
    }
}
