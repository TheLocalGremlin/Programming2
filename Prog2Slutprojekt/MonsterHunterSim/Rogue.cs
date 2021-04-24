using System;

namespace MonsterHunterSim
{
    public class Rogue: Hunter
    {
        public Rogue()
        {
            hunterHP = 15;

            baseDMG = 5;
            baseHitChance = 6;
            specialAttackDMG = 8;
            specialAttackChance = 8;
        }
        
    }
}
