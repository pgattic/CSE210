
using Raylib_cs;

namespace snake {
    static class Program {
        public static void Main() {
            Raylib.InitWindow(800, 600, "Snake");
            Raylib.SetTargetFPS(60);
            int frames = 0;

            Snake snake = new Snake(1, 1, Direction.Right, 5, Color.DARKBLUE);

            while (!Raylib.WindowShouldClose()) {
                if (frames % 4 == 0) {
                    snake.Advance();
                }
                frames++;
                snake.SetDirection();
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.WHITE);

                Raylib.DrawText("Hello, world!", 12, 12, 20, Color.BLACK);
                snake.Render();

                Raylib.EndDrawing();
            }

            Raylib.CloseWindow();
        }
    }
}

