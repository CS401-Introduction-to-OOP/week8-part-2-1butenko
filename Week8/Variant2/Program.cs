using Variant2;

Point p1 = new Point { X = 1, Y = 2 };
Point p2 = p1;
p2.X = 99;                          
Console.WriteLine($"p1 = {p1}");
Console.WriteLine($"p2 = {p2}");
Console.WriteLine();

PointRef r1 = new PointRef { X = 1, Y = 2 };
PointRef r2 = r1;
r2.X = 99;
Console.WriteLine($"r1 = {r1}");
Console.WriteLine($"r2 = {r2}");
Console.WriteLine();

BoxingTester.Test();