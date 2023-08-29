using System.Collections.Generic;
using Raylib_cs;

namespace snake {
    public class ControlHandler {
        List<Direction> _directionQueue = new List<Direction>();
        KeyboardKey _upKey;
        KeyboardKey _leftKey;
        KeyboardKey _downKey;
        KeyboardKey _rightKey;

        bool _previousUp;
        bool _previousLeft;
        bool _previousDown;
        bool _previousRight;

        public ControlHandler(Direction initialDirection, KeyboardKey upKey, KeyboardKey leftKey, KeyboardKey downKey, KeyboardKey rightKey) {
            _directionQueue.Add(initialDirection);
            _upKey = upKey;
            _leftKey = leftKey;
            _downKey = downKey;
            _rightKey = rightKey;
        }

        public Direction GetDirection() {
            Direction result = _directionQueue[0];
            if (_directionQueue.Count > 1) {
                _directionQueue.RemoveAt(0);
            }
            return result;
        }

        public void Update() {
            if (Raylib.IsKeyPressed(_upKey) != _previousUp) {
                if (Raylib.IsKeyPressed(_upKey) && _directionQueue[_directionQueue.Count-1] != Direction.Up && _directionQueue[_directionQueue.Count-1] != Direction.Down) {
                    _directionQueue.Add(Direction.Up);
                }
                _previousUp = Raylib.IsKeyPressed(_upKey);
            }

            if (Raylib.IsKeyPressed(_leftKey) != _previousLeft) {
                if (Raylib.IsKeyPressed(_leftKey) && _directionQueue[_directionQueue.Count-1] != Direction.Left && _directionQueue[_directionQueue.Count-1] != Direction.Right) {
                    _directionQueue.Add(Direction.Left);
                }
                _previousLeft = Raylib.IsKeyPressed(_leftKey);
            }

            if (Raylib.IsKeyPressed(_downKey) != _previousDown) {
                if (Raylib.IsKeyPressed(_downKey) && _directionQueue[_directionQueue.Count-1] != Direction.Up && _directionQueue[_directionQueue.Count-1] != Direction.Down) {
                    _directionQueue.Add(Direction.Down);
                }
                _previousDown = Raylib.IsKeyPressed(_downKey);
            }

            if (Raylib.IsKeyPressed(_rightKey) != _previousRight) {
                if (Raylib.IsKeyPressed(_rightKey) && _directionQueue[_directionQueue.Count-1] != Direction.Left && _directionQueue[_directionQueue.Count-1] != Direction.Right) {
                    _directionQueue.Add(Direction.Right);
                }
                _previousRight = Raylib.IsKeyPressed(_rightKey);
            }
        }

        public void BindKeys(KeyboardKey upKey, KeyboardKey leftKey, KeyboardKey downKey, KeyboardKey rightKey) {
            _upKey = upKey;
            _leftKey = leftKey;
            _downKey = downKey;
            _rightKey = rightKey;
        }
    }
}
