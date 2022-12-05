// // Задача 45: Напишите программу, которая 
// // будет создавать копию заданного массива 
// // с помощью поэлементного копирования.


int[] CreateArrayRndInt(int size, int min, int max) // Метод создания массива
{
    int[] arr = new int[size]; // по умолчанию создается массив размером size, заполненный нулями.
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
    }
    Console.WriteLine("]");
}

int[] CopyArray(int[] arr)
{
    int[] tempArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        tempArray[i] = arr[i];
    }
    return tempArray;
}

int[] array1 = CreateArrayRndInt(5, 1, 10);
PrintArray(array1);
int[] array2 = CopyArray(array1);
array2[0] = 2022;
PrintArray(array2);