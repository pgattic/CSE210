using System.Collections.Generic;
//using System.Linq;
using Raylib_cs;

namespace snake {
    public class Snake {
        
        Direction _direction;
        Color _color;
        ControlHandler _controlHandler;
        int _score;
        int _originX;
        int _originY;
        bool _dead = false;
        
        List<SquareMapElement> _body;

        public Snake(int originX, int originY, Direction direction, int length, Color color) {
            _originX = originX;
            _originY = originY;
            _direction = direction;
            _color = color;
            _score = length;
            _controlHandler = new ControlHandler(_direction, KeyboardKey.KEY_UP, KeyboardKey.KEY_LEFT, KeyboardKey.KEY_DOWN, KeyboardKey.KEY_RIGHT);

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

        public void Feed(int points = 5) {
            _score += points;
        }

        public bool GetDead() {
            return _dead;
        }

        public int GetXPosition() {
            return _body[0].GetXPosition();
        }

        public int GetYPosition() {
            return _body[0].GetYPosition();
        }

        public bool HeadInBounds() {
            return _body[0].InBounds();
        }
        
        public void Render() {
            foreach (SquareMapElement i in _body) {
                i.Render();
            }
        }

        public void RenderScore() {
            Raylib.DrawText(_score.ToString(), (int)(_originX * Constants.CellSize * 0.95) + 12, (int)(_originY * Constants.CellSize * 0.95) + 12, 20, Color.BLACK);
        }

        public void SetDead(bool dead) {
            _dead = dead;
        }
        
        public void SetDirection() {
            _controlHandler.Update();
        }

        public bool TouchesMe(int x, int y, bool isSelf = false) {
            bool result = false;
            for (int i = (isSelf?1:0); i < _body.Count; i++) {
                result |= (_body[i].GetXPosition() == x && _body[i].GetYPosition() == y);
            }
            return result;
           // return _body.Aggregate(false, (result, i) => (result | (i.GetXPosition() == x && i.GetYPosition() == y))); // potential alternative???
        }
    }
}
