using System;

namespace MonsterHunterSim
{
    public class Lvl2Hunt: Hunt
    {
        public Lvl2Hunt()
        {
            XP = 15;
            payment = 25;
            difficulty = 2;

            monsterDMG = 5;
            monsterHitChance = 12;
        }
    }
}
