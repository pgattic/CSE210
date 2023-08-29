using Raylib_cs;

namespace snake {
    public class CircleMapElement: MapElement {
        

        public CircleMapElement(Color color, int x, int y): base(color, x, y) {

        }

        public override void Render() {
            Raylib.DrawCircle(GetDrawXPosition() + Constants.CellSize/2, GetDrawYPosition() + Constants.CellSize/2, Constants.CellSize/2, GetColor());
        }
    }
}
