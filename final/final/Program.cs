
using Raylib_cs;

namespace snake {
    static class Program {
        public static void Main() {
            Raylib.InitWindow(Constants.ScreenWidth, Constants.ScreenHeight, "Snake");
            Raylib.SetTargetFPS(60);
            int frames = 0;

            PhysicsContainer physics = new PhysicsContainer();


            while (!Raylib.WindowShouldClose()) {
                if (frames % 4 == 0) {
                    physics.Step();
                }
                frames++;
                physics.Planck();
            }

            Raylib.CloseWindow();
        }
    }
}

