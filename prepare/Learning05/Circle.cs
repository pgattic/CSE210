namespace Learning05 {
    public class Circle: Shape {
        double _radius;

        public Circle (string color, double radius): base(color) {
            _radius = radius;
        }

        public override double GetArea() {
            return _radius * _radius * 3.14159265359;
        }
    }
}
