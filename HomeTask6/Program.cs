// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

if(number % 2 == 0) {
    Console.Write("введенное число является четным -да");
    Console.Read();
}
else {
    Console.Write("введенное число является четным - нет");
    Console.Read();
}
