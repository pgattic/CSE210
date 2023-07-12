using Raylib_cs;

namespace snake {
    public abstract class MapElement {
        Color _color;
        int _x;
        int _y;
        int _cellSize = 20;

        public MapElement(Color color, int x, int y) {
            _color = color;
            _x = x;
            _y = y;
        }

        public abstract void Render();

        public Color GetColor() {
            return _color;
        }

        public int GetCellSize() {
            return _cellSize;
        }

        public int GetDrawXPosition() {
            return _x * _cellSize;
        }

        public int GetDrawYPosition() {
            return _y * _cellSize;
        }

        public int GetXPosition() {
            return _x;
        }

        public int GetYPosition() {
            return _y;
        }

        public void SetXPosition(int x) {
            _x = x;
        }

        public void SetYPosition(int y) {
            _y = y;
        }
    }
}
