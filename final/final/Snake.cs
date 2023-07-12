using System.Collections.Generic;
using Raylib_cs;

namespace snake {
    public class Snake {
        
        Direction _direction;
        Color _color;
        ControlHandler _controlHandler;
        int _score;
        
        List<SquareMapElement> _body;

        public Snake(int originX, int originY, Direction direction, int length, Color color) {
            _direction = direction;
            _color = color;
            _score = length;
            _controlHandler = new ControlHandler(Direction.Right, KeyboardKey.KEY_UP, KeyboardKey.KEY_LEFT, KeyboardKey.KEY_DOWN, KeyboardKey.KEY_RIGHT);

            _body = new List<SquareMapElement>();
            while (_body.Count < length) {
                _body.Add(new SquareMapElement(color, originX, originY));
            }
        }

        public void Advance() {
            SquareMapElement newHead = new SquareMapElement(_body[0].GetColor(), _body[0].GetXPosition(), _body[0].GetYPosition());
            switch (_controlHandler.GetDirection()) {
                case Direction.Up:
                    newHead.SetYPosition(newHead.GetYPosition() - 1);
                    break;
                case Direction.Down:
                    newHead.SetYPosition(newHead.GetYPosition() + 1);
                    break;
                case Direction.Left:
                    newHead.SetXPosition(newHead.GetXPosition() - 1);
                    break;
                case Direction.Right:
                    newHead.SetXPosition(newHead.GetXPosition() + 1);
                    break;
            }
            _body.Insert(0, newHead);
            if (_body.Count > _score) {
                _body.RemoveAt(_body.Count - 1);
            }
        }

        public void BindKeys(KeyboardKey upKey, KeyboardKey leftKey, KeyboardKey downKey, KeyboardKey rightKey) {
            _controlHandler.BindKeys(upKey, leftKey, downKey, rightKey);
        }
        public void Render() {
            foreach (SquareMapElement i in _body) {
                i.Render();
            }
        }
        public void SetDirection() {
            _controlHandler.Update();
        }
    }
}
