using System;
using Raylib_cs;

namespace Graphics
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Aloha Brochaskis");

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground(Color.PURPLE);
                
                Raylib.EndDrawing();
            }

        }
    }
}
