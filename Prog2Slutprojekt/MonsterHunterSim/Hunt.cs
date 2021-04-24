using System;

namespace MonsterHunterSim
{
    public class Hunt
    {
        int XP;
        int payment;
        int difficulty;

        int monsterHP;

        public int monsterDMG;
        public int monsterHitChance;

        Random generator = new Random();

        public Hunt()
        {
            int h = generator.Next(8, 12);
            monsterHP = difficulty * h;
        }

        public void combat (int playerHP, int playerBaseDMG, int playerBaseHitChance, int playerSpecialAttackDMG, int playerSpecialAttackChance)
        {
            int playerTurn;
            int enemyTurn;

            bool combat = true;
            bool lose = false;

            bool playerDefense = false;
            bool enemyDefense = false;

            while (combat == true)
            {
                Console.Clear();

                System.Console.WriteLine("Your HP: " + playerHP);
                System.Console.WriteLine("Enemy HP: " + monsterHP);

                playerDefense = false;

                playerTurn = generator.Next(1, 20);

                if (playerTurn <= 7)
                {
                    int dmg;
                    int hit;

                    if (enemyDefense == true)
                    {
                        hit = generator.Next(1, 15);
                    }

                    else
                    {
                        hit = generator.Next(1, 20);
                    }

                    if (hit >= playerBaseHitChance)
                    {
                        dmg = generator.Next(1, playerBaseDMG);
                        monsterHP -= dmg;
                    }
                }

                if (playerTurn > 7 && playerTurn < 12)
                {
                    int dmg;
                    int hit;

                    if (enemyDefense == true)
                    {
                        hit = generator.Next(1, 15);
                    }

                    else
                    {
                        hit = generator.Next(1, 20);
                    }

                    if (hit >= playerSpecialAttackChance)
                    {
                        dmg = generator.Next(1, playerSpecialAttackDMG);
                        monsterHP -= dmg;
                    }
                }

                if (playerTurn > 12 && playerTurn < 17)
                {
                    playerDefense = true;
                }

                else if (playerTurn >= 17)
                {

                }

                if (monsterHP < 1)
                {
                    combat = false;
                    break;
                }

                playerDefense = false;


                enemyTurn = generator.Next(1, 20);

                if (enemyTurn <= 12)
                {
                    int dmg;
                    int hit;

                    if (playerDefense == true)
                    {
                        hit = generator.Next(1, 15);
                    }

                    else
                    {
                        hit = generator.Next(1, 20);
                    }

                    if (hit >= monsterHitChance)
                    {
                        dmg = generator.Next(1, monsterDMG);
                        monsterHP -= dmg;
                    }
                }

                if (playerTurn > 12 && playerTurn < 17)
                {
                    enemyDefense = true;
                }

                else if (playerTurn >= 17)
                {

                }

                if (playerHP < 1)
                {
                    combat = false;
                    lose = true;
                    break;
                }
            }

        }
    }
}
