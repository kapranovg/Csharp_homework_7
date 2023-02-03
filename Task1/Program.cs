/*Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.
0,5  7    -2   -0,2
1   -3,3   8   -9,9
8    7,8  -7,1  9*/

int InputInt(string message)
{
    System.Console.WriteLine(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

double[,] CreateArray(int row, int col)
{
    Random rnd = new Random();
    double[,] array = new double[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(-10, 10) + rnd.NextDouble();
        }
    }
    return array;
}

void PrinArray(double[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]:F2}" + "\t");
        }
    }
    System.Console.WriteLine();
}

int rowM = InputInt("Введите количество строк массива");
int columnN = InputInt("Введите количество столбцов массива");
double[,] baseArray = CreateArray(rowM, columnN);
PrinArray(baseArray);