using System;

namespace Modellering
{
    class Program
    {
        static void Main(string[] args)
        {
            audience a1 = new audience();

            a1.excitement = 30;

            fotboll theBall = new fotboll();
            fotboll theOtherBall = new fotboll();

            theBall.x = 250;

            System.Console.WriteLine(theOtherBall.x);
            Console.ReadLine();
        }
    }
}
