/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

1, 7 -> такого числа в массиве нет
1, 2 -> 4*/

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

(bool, int) FindNumber(int[,] array, int x, int y)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == x - 1 && j == y - 1) return (true, array[i, j]);
        }
    }
    return (false, 0);
}

int rowM = InputInt("Введите количество строк массива");
int columnN = InputInt("Введите количество столбцов массива");
int[,] baseArray = CreateArray(rowM, columnN);
PrinArray(baseArray);
int xCord = InputInt("Введите строку искомого элемента");
int yCord = InputInt("Введите столбец искомого элемента");
(bool check, int result) = FindNumber(baseArray, xCord, yCord);
if (check)
{
    System.Console.WriteLine($"Искомый элемент с координатами [{xCord}, {yCord}] = {result}.");
}
else
{
    System.Console.WriteLine($"Искомый элемент с координатами [{xCord}, {yCord}] не существует в текущем массиве.");
}
