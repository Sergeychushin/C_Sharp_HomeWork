// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] GetArray(int size, int minValue, int maxValue)

{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(maxValue + 1);
    }
    return result;
}

int[] array = GetArray(8, 0, 235);
Console.WriteLine(String.Join(" ", array));

int max = array[0];
int min = array[0];

for (int i = 1; i < array.Length; i++)
{
    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i];
}
Console.WriteLine("Разность между максимальным и минимальным = {0}", max - min);