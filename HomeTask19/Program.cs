// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет, 12821 -> да, 23432 -> да

Console.Clear();

Console.WriteLine("Введите пятизначное число: ");
int number = int.Parse(Console.ReadLine()!);

if (number > 10000 & number < 100000) {
    int a1 = number / 10000;
    int a2 = number % 10;
    int b1 = number / 1000 % 10;
    int b2 = b1 % 100 % 10;
    if (a1 == a2 & b1 == b2) {
        Console.Write("Да"); 
        }
    else {
        Console.Write("Нет"); 
        }
}
else {
   Console.Write("Вы ввели неверное число");  
}
