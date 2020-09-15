using System;

namespace ModelleringUppgift
{
    class Program
    {
        static void Main(string[] args)
        {
            player p1 = new player();

            bullet b1 = new bullet();
            b1.posX = 50;

            p1.hp -= shot(b1.posX, p1.posX, b1.posY, p1.posY);

            Console.ReadLine();

            p1.posX = 50;

            p1.hp = shot(b1.posX, p1.posX, b1.posY, p1.posY);


        }

        static int shot(int b1posX, int p1posX, int b1posY, int p1posY)
        {
            int dmg;

            if (b1posX == p1posX && b1posY == p1posY)
            {
                Console.WriteLine("Ow");
                dmg = 20;
            }

            else
            {
                Console.WriteLine("They missed");
                dmg = 0;
            }

            return dmg;
        }
    }
}
