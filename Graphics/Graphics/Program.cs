using System;
using Raylib_cs;

namespace Graphics
{
    class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 600, "Aloha Brochaskis");

            Color porble = new Color(100, 25, 148, 255);
            Color mint = new Color(51, 255, 204, 255);

            float x = 0;
            float y = 0;

            while (!Raylib.WindowShouldClose())
            {
                if (Raylib.IsKeyDown(KeyboardKey.KEY_RIGHT))
                {
                    x += 0.1f;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_LEFT))
                {
                    x -= 0.1f;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_DOWN))
                {
                    y += 0.1f;
                }

                if (Raylib.IsKeyDown(KeyboardKey.KEY_UP))
                {
                    y -= 0.1f;
                }


                Raylib.BeginDrawing();

                Raylib.DrawRectangle((int)x, (int)y, 10, 10, mint);

                Raylib.ClearBackground(porble);
                
                Raylib.EndDrawing();
            }

        }
    }
}
