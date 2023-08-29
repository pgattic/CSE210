using Raylib_cs;

namespace snake {
    public class SquareMapElement: MapElement {
        

        public SquareMapElement(Color color, int x, int y): base(color, x, y) {

        }

        public override void Render() {
            Raylib.DrawRectangle(GetDrawXPosition(), GetDrawYPosition(), Constants.CellSize, Constants.CellSize, GetColor());
        }
    }
}
