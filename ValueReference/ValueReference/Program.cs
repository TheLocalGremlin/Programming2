using System;

namespace ValueReference
{
    class Program
    {
        static void Main(string[] args)
        {
            // int t = 40;

            PowerUp fungus = new PowerUp();
            fungus.name = "Fungi";

            Modify(fungus);

            System.Console.WriteLine(fungus.name);

            Console.ReadLine();
        }

        static void Modify (PowerUp p)
        {
            p.name = "E-container";
        }
        // static void Modify(int u)
        // {
        //     u += 10;
        // }
    }
}
