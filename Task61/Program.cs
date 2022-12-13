// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

int[] MatrixToArray(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(0);
    int[] arr = new int[matrix.Length];
    int index = 0;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            arr[index] = matrix[i, j];
            index++;
        }
    }
    return arr;
}

void PrintArray(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int SizeRequencyElemsArray(int[] arr)
{
    int size = 0;
    int temp = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] != temp)
        {
            size++;
            temp = arr[i];
        }
    }
    return size;
}

int[,] RequencyElemsArray(int[] arr)
{
    int size = SizeRequencyElemsArray(arr);
    int temp = 0;
    int[,] matrix = new int[size, 2];
    int index = -1;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] != temp)
        {
            index++;
            temp = arr[i];
            matrix[index, 0] = arr[i];
        }
        if(arr[i] == temp)
        matrix[index, 1]++;
    }
    return matrix;
} 

void PrintMatrixSpecial(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"число {matrix[i, j],2} встречается");
            else Console.Write($"{matrix[i, j],2} раз");
        }
        Console.WriteLine("|");
    }
}

int[,] array2D = CreateMatrixRndInt(4, 4, 1, 10);
PrintMatrix(array2D);
Console.WriteLine();
int[] array = MatrixToArray(array2D);
Array.Sort(array);
PrintArray(array);
Console.WriteLine();
int[,] requencyElemsArray = RequencyElemsArray(array);
PrintMatrixSpecial(requencyElemsArray);
