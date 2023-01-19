// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. (Цифры считать справа налево).
// 645 -> 6
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Clear();

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);

if (number < 100) {
    Console.Write("Третьей цифры нет");
}

else {
    if (number < 1000) {
        int num1 = number / 100;
        Console.WriteLine($" число {number} -> {num1}"); 
    }
    else {
        int num3 = number / 100 % 10;
        Console.WriteLine($" число {number} -> {num3}");
    }
}
