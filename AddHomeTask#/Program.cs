//Разобраться с алгоритмом сортировки методом пузырька. Реализовать невозрастающую сортировку.
//[3, 0, 2, 4, -1] -> [4, 3, 2, 0, -1]
//[1,2,2,3,2] -> [3, 2, 2, 2, 1]

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

int temp;
for (int i = 0; i < array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] < array[j])
        {
            temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }                  
    }           
 }
    

Console.WriteLine($"Невозрастающая сортировка = {String.Join(" ", array)}");