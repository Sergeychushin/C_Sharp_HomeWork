// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Clear();

Console.WriteLine("Введите число дня недели от 1 до 7: ");
int number = int.Parse(Console.ReadLine()!);

if (number >= 1 & number <= 7 ) 
{
    if (number >= 6) {
        Console.Write("Является ли этот день выходным - Да");
    }
    else
    Console.Write("Является ли этот день выходным - Нет");
}
else 
{
    Console.WriteLine("Вы ввели неверное число!");
}