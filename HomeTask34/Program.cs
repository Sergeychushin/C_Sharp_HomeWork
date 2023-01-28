//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] GetArray(int size, int maxValue)

{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(maxValue + 1);
    }
    return result;
}

int[] array = GetArray(8, 235);
Console.WriteLine(String.Join(" ", array));

int evenElCount = 0;

foreach (int el in array)
{
    if (el % 2 == 0) 
    {
        evenElCount++;
      
    }
        
}
Console.WriteLine($"Масиив = {String.Join(" ", array)} -> {evenElCount} ");