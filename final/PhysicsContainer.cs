using System.Collections.Generic;
using System;
using Raylib_cs;

namespace snake {
    public class PhysicsContainer {
        List<Snake> _players;
        List<CircleMapElement> _foods;

        public PhysicsContainer() {

            _players = new List<Snake>();
            _foods = new List<CircleMapElement>();

            Snake player1 = new Snake(0, 0, Direction.Right, 5, Color.DARKBLUE);
            player1.BindKeys(KeyboardKey.KEY_W, KeyboardKey.KEY_A, KeyboardKey.KEY_S, KeyboardKey.KEY_D);
            _players.Add(player1);

            Snake player2 = new Snake(Constants.MapWidth-1, 0, Direction.Left, 5, Color.DARKGREEN);
            player2.BindKeys(KeyboardKey.KEY_T, KeyboardKey.KEY_F, KeyboardKey.KEY_G, KeyboardKey.KEY_H);
            _players.Add(player2);

            Snake player3 = new Snake(0, Constants.MapHeight-1, Direction.Right, 5, Color.YELLOW);
            player3.BindKeys(KeyboardKey.KEY_I, KeyboardKey.KEY_J, KeyboardKey.KEY_K, KeyboardKey.KEY_L);
            _players.Add(player3);

            Snake player4 = new Snake(Constants.MapWidth-1, Constants.MapHeight-1, Direction.Left, 5, Color.RED);
            _players.Add(player4);

        }

        public void Planck() { // Titled "planck" after Max Planck's "Planck Time", since this function is called as often in time as possible.

            // Physics
            for (int s = 0; s < _players.Count; s++) {
                _players[s].SetDirection();
                if (!_players[s].HeadInBounds()) {
                    _players[s].SetDead(true);
                    continue;
                }
                for (int t = 0; t < _players.Count; t++) {
                    if (_players[t].TouchesMe(_players[s].GetXPosition(), _players[s].GetYPosition(), s == t)) {
                        _players[s].SetDead(true);
                    }
                }
            }

            while (_foods.Count < 3) {
                _foods.Add(new CircleMapElement(Color.BLUE, new Random().Next(0, Constants.MapWidth), new Random().Next(0, Constants.MapHeight)));
            }

            for (int s = 0; s < _players.Count; s++) {
                if (_players[s].GetDead()) {
                    _players.RemoveAt(s);
                    s--;
                    continue;
                }
                for (int f = 0; f < _foods.Count; f++) {
                    if (_players[s].TouchesMe(_foods[f].GetXPosition(), _foods[f].GetYPosition())) {
                        _players[s].Feed();
                        _foods.RemoveAt(f);
                        f--;
                    }
                }
            }
            
            // Rendering
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.WHITE);

            foreach (CircleMapElement f in _foods) {
                f.Render();
            }
            foreach (Snake s in _players) {
                s.Render();
            }

            foreach (Snake s in _players) {
                s.RenderScore();
            }

            Raylib.EndDrawing();
        }

        public void Step() { // As opposed to "Planck", this function is called only when the snakes need to advance
            for (int subject = 0; subject < _players.Count; subject++) {
                _players[subject].Advance();
                for (int target = 0; target < _players.Count; target++) {
                    if (subject != target && _players[target].TouchesMe(_players[subject].GetXPosition(), _players[subject].GetYPosition())){
                        _players[subject].SetDead(true);
                    }
                }
            }
        }
    }
}
