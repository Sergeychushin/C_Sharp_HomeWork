//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            double num = Math.Round(matrix[i, j], 1);
            Console.Write(num + " ");
        }
    Console.WriteLine();
    }
}
void CreateArrayDouble(double[,] matr)
{
      for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
          matr[i, j] = new Random().NextDouble()*20 -10; 
        }
    }
}

double[,] matrix = new double[m, n];

CreateArrayDouble(matrix);
PrintArray(matrix);