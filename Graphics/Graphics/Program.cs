using System;
using Raylib_cs;

namespace Graphics
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Aloha Brochaskis");

            while (!Raylib.WindowSouldClose())
            {
                Raylib.BeginDrawing();

                Raylib.ClearBackground()

                Raylib.EndDrawing();
            }

        }
    }
}
