// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();

Console.WriteLine("Введите координату X точки A:  ");
int x1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату y точки A:  ");
int y1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату z точки A:  ");
int z1 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату X точки B:  ");
int x2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату y точки B:  ");
int y2 = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите координату z точки B:  ");
int z2 = int.Parse(Console.ReadLine()!);

int x = x2 - x1;
int y = y2 - y1;
int z = z1 - z2;

double length = Math.Sqrt(x * x + y * y + z * z);


Console.WriteLine($"Длинна отрезка {Math.Round(length, 2)}");