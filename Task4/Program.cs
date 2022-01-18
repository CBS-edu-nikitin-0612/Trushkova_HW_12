// See https://aka.ms/new-console-template for more information
using Task4;

Console.WriteLine("Hello, World!");

Point pointA = new Point(1, 2, "A");
Point pointB = new Point(2, 3, "B");
Point pointC = new Point(3, 4, "C");
Point pointD = new Point(2, 5, "D");
Point pointE = new Point(1, 4, "E");

Figure figure1 = new Figure(pointA, pointB, pointC, pointD);
Console.WriteLine($"Название многоугольника: {figure1.Name}");
Console.WriteLine($"Периметр многоугольника {figure1.Name} равен {figure1.Perimetr}");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Figure figure2 = new Figure(pointA, pointB, pointC);
Console.WriteLine($"Название многоугольника: {figure2.Name}");
Console.WriteLine($"Периметр многоугольника {figure2.Name} равен {figure2.Perimetr}");

Console.ForegroundColor = ConsoleColor.DarkGreen;
Figure figure3 = new Figure(pointA, pointB, pointC, pointD, pointE);
Console.WriteLine($"Название многоугольника: {figure3.Name}");
Console.WriteLine($"Периметр многоугольника {figure3.Name} равен {figure3.Perimetr}");