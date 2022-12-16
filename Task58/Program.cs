// Задача 58: Задайте две матрицы. 
// Напишите программу, которая 
// будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

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

int[,] CreateMatrixRndInt2(int rows, int columns, int min, int max)
{
    int[,] matrix2 = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            matrix2[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix2;
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

int[,] TwoMatrixProduct(int[,] matrix, int[,] matrix2)
{
    int[,] twoMatrixProduct = new int[matrix.GetLength(0), matrix2.GetLength(1)];
    if (matrix.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < twoMatrixProduct.GetLength(0); i++)
        {
            for (int j = 0; j < twoMatrixProduct.GetLength(1); j++)
            {
                twoMatrixProduct[i, j] = 0;
                for (int k = 0; k < twoMatrixProduct.GetLength(1); k++)
                {
                    twoMatrixProduct[i, j] += matrix[i, k] * matrix2[k, j];

                }
            }
        }
    }
    return twoMatrixProduct;
}

int[,] matrix = CreateMatrixRndInt(2, 2, 2, 4);
int[,] matrix2 = CreateMatrixRndInt2(2, 2, 2, 4);
PrintMatrix(matrix);
Console.WriteLine();
PrintMatrix(matrix2);
Console.WriteLine("Произведение двух матриц:  ");
int [,] twoMatrixProduct = TwoMatrixProduct(matrix, matrix2);
PrintMatrix(twoMatrixProduct);




