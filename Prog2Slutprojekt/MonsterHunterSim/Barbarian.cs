using System;

namespace MonsterHunterSim
{
    public class Barbarian: Hunter
    {
        public Barbarian()
        {
            hunterHP = 25;

            baseDMG = 6;
            baseHitChance = 10;
            specialAttackDMG = 14;
            specialAttackChance = 15;
        }
        
        public override void Spawn()
        {
            hunterHP = 25;

            baseDMG = 6;
            baseHitChance = 10;
            specialAttackDMG = 14;
            specialAttackChance = 15;
        }
    }
}
