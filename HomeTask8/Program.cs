// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int count = 0;

while(count <= number){
      if(number % 2 == 0) {
        Console.Write($"{count} ");
        count = count + 2;
      }

}