using System;

namespace MonsterHunterSim
{
    public class Player
    {
        public string username;

        public int bountiesTaken;
        public int money;
        public int XP;

        public Player()
        {
            bountiesTaken = 0;
            money = 0;
        }
    }
}