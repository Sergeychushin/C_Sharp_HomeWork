//Напишите функцию, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Нельзя использовать библиотеку Math!
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.Clear();

Console.WriteLine("Введите число A:  ");
int a = int.Parse(Console.ReadLine()!);

Console.WriteLine("Введите число В:  ");
int b = int.Parse(Console.ReadLine()!);

Math.Pow(a, b);
Console.Write($" число A: {a} B: {b} -> {Math.Pow(a, b)} ");

 
