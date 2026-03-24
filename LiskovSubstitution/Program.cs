using LiskovSubstitution;

var rectangle = new Rectangle(5, 10);
Console.WriteLine($"{rectangle} Area: {AreaCalculator.CalculateArea(rectangle)}");

Rectangle square = new Square { Width = 5 };
Console.WriteLine($"{square} Area: {AreaCalculator.CalculateArea(square)}");