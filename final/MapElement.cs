using Raylib_cs;

namespace snake {
    public abstract class MapElement {
        Color _color;
        int _x;
        int _y;

        public MapElement(Color color, int x, int y) {
            _color = color;
            _x = x;
            _y = y;
        }

        public abstract void Render();

        public Color GetColor() {
            return _color;
        }

        public int GetDrawXPosition() {
            return _x * Constants.CellSize;
        }

        public int GetDrawYPosition() {
            return _y * Constants.CellSize;
        }

        public int GetXPosition() {
            return _x;
        }

        public int GetYPosition() {
            return _y;
        }

        public bool InBounds() {
            return _x >= 0 && _y >= 0 && _x < Constants.MapWidth && _y < Constants.MapHeight;
        }

        public void SetXPosition(int x) {
            _x = x;
        }

        public void SetYPosition(int y) {
            _y = y;
        }
    }
}
