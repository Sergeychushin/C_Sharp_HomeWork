﻿//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0
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

int sum = 0;

for (int i = 1; i < array.Length; i+=2)
{
     sum = sum + array[i];
}

Console.WriteLine("Cумма элементов, стоящих на нечётных позициях = {0}", sum);