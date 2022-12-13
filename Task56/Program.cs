// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая 
// будет находить строку с наименьшей суммой элементов.
// Например, задан массив:

//  1 | 4 | 7 | 2
// ---------------
//  5 | 9 | 2 | 3
// ---------------
//  8 | 4 | 2 | 4
// ---------------
//  5 | 2 | 6 | 7

// Программа считает сумму элементов в каждой строке
// и выдаёт номер строки с наименьшей суммой элементов: 1 строка

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];  // 0,1
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],4}, ");
            else Console.Write($"{matrix[i, j],4}");
        }
        Console.WriteLine("|");
    }
}

int[] SumRowElements(int[,] matrix)
{
    int[] sumRowElements = new int[matrix.GetLength(0)];
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum = sum + matrix[i, j];
            sumRowElements[i] = sum;
        }
        sum = 0;
    }
    return sumRowElements;
}

void PrintArray(int[] arr)
{
    Console.Write("|");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("|");
}

(int,int) NumberRowMinSum(int[] array)
{
    int minSum = array[0];
    int numberRow = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minSum)
        {
            minSum = array[i];
            numberRow = i;
        }
    }
    return (minSum, numberRow);
}
 
int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int[] sumRowElements = SumRowElements(array2D);
PrintArray(sumRowElements);
Console.WriteLine();
(int,int) numberRowMinSum = NumberRowMinSum(sumRowElements);
Console.WriteLine($"Наименьшая сумма элементов с номером строки: {numberRowMinSum} ");