//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

int a1 = number / 100 * 100;
int a2 = number % 10;
int num = (number - (a1 + a2)) / 10;

Console.WriteLine($"Трехзначное число {number} -> {num}"); 