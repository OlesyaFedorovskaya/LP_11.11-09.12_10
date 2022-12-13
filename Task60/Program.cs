﻿// Задача 60. Сформируйте трёхмерный массив 
// из неповторяющихся двузначных чисел. 
// Напишите программу, которая 
// будет построчно выводить массив, 
// добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 27(0,0,1) 25(0,1,0) 90(0,1,1)
// 34(1,0,0) 26(1,0,1) 41(1,1,0) 55(1,1,1)


int[,,] CreateMatrixRndInt(int rows, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[rows, columns, depth];  // 0,1,2
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++) //строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // столбцы
        {
            for (int k = 0; k < matrix.GetLength(2); k++) // depth
            {
                matrix[i, j, k] = rnd.Next(min, max + 1); // 2 - 3
                Console.Write($"{matrix[i, j, k]} ({i}, {j}, {k})");
            }
        }
    }
    return matrix;
}

void PrintMatrix(int[,,] matrix, int )
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write("|");
            for (int k = 0; k < matrix.GetLength(1); k++)
                if (k < matrix.GetLength(2) - 1) Console.Write($"{matrix[i, j, k],4}, ");
                else Console.Write($"{matrix[i, j, k],4}");
        }
        Console.WriteLine("|");
    }
}

int[,,] array3D = CreateMatrixRndInt(2 * 2 * 2, 1, 9);
PrintMatrix(array3D);