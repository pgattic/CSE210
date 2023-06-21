namespace Learning05 {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello Learning05 World!");
            List<Shape> shapes = new List<Shape>();

            Shape rectangle = new Rectangle("Red", 40, 30);
            Shape square = new Square("Blue", 26);
            Shape circle = new Circle("Brown", 20);
            shapes.Add(rectangle);
            shapes.Add(square);
            shapes.Add(circle);

            foreach(Shape shape in shapes) {
                Console.WriteLine($"Shape Color: {shape.GetColor()}, Shape Area {shape.GetArea()}");
            }
        }
    }
}
