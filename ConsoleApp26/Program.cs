using ConsoleApp26;

// Create a ShapeManager object
ShapeManager shapeManager = new();

// Adding shapes
shapeManager.AddShape(new Circle(5));
shapeManager.AddShape(new Rectangle(4, 4));
shapeManager.AddShape(new Circle(3));
shapeManager.AddShape(new Rectangle(6, 6));

// Call the methods
Console.WriteLine($"Number of Circles: {shapeManager.GetCircleCount()}");

Circle[] circles = shapeManager.GetCircles();
Console.WriteLine("Circles:");
foreach (var circle in circles) {
    Console.WriteLine($"Radius: {circle.Radius}");
}

Console.WriteLine($"Total Circle Areas: {shapeManager.GetTotalCircleAreas():#.##}");

Console.WriteLine($"Number of Squares: {shapeManager.GetSquareCount()}");

Console.ReadLine();