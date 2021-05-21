using System;

namespace MonsterHunterSim
{
    public class Lvl3Hunt: Hunt
    {
        public Lvl3Hunt()
        {
            XP = 20;
            payment = 35;
            difficulty = 3;

            monsterDMG = 5;
            monsterHitChance = 14;
        }
    }
}
