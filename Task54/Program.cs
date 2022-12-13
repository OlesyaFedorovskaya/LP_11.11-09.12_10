// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:       В итоге получается вот такой массив:

//   1 | 4 | 7 | 2                 7 | 4 | 2 | 1
//  ---------------               ---------------
//   5 | 9 | 2 | 3                 9 | 5 | 3 | 2
//  ---------------               ---------------
//   8 | 4 | 2 | 4                 8 | 4 | 4 | 2


int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
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

void SortArrayElements(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int num = 0; num < matrix.GetLength(1) - 1; num++)
            {
                if (matrix[i, num] < matrix[i, num + 1])
                {
                    int temp = matrix[i, num + 1];
                    matrix[i, num + 1] = matrix[i, num];
                    matrix[i, num] = temp;
                }
            }
        }
    }
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
Console.WriteLine("Результат сортировки массива по убыванию: ");
SortArrayElements(array2D);
PrintMatrix(array2D);