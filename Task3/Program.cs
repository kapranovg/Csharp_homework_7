/*Задайте двумерный массив из целых чисел. 
Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int InputInt(string message)
{
    System.Console.WriteLine(message + ": ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] CreateArray(int row, int col)
{
    Random rnd = new Random();
    int[,] array = new int[row, col];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrinArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.WriteLine();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + "\t");
        }
    }
    System.Console.WriteLine();
}

double[] FindColumnAverage(int[,] array)
{
    double sum = 0;
    int index = 0;
    double[] averageArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        averageArray[index] = sum / array.GetLength(0);
        index++;
        sum = 0;
    }
    return averageArray;
}

void PrintAverageArray(double[] array, string message)
{
    System.Console.WriteLine(message + ": ");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]:F1}" + "\t");
    }
}

int rowM = InputInt("Введите количество строк массива");
int columnN = InputInt("Введите количество столбцов массива");
int[,] baseArray = CreateArray(rowM, columnN);
PrinArray(baseArray);
PrintAverageArray(FindColumnAverage(baseArray), "Среднее арифметическое каждого столбца");