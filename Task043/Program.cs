// Точка пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2

Console.WriteLine("Введите k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите k2: ");
double k2 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите b2: ");
double b2 = int.Parse(Console.ReadLine());


double y = (k1 * (b2 - b1)) / (k1 - k2) + b1;
double x = (b2 - b1) / (k1 - k2);

Console.WriteLine($"({x},{y})");
