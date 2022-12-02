// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

// [3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CreateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double MaxDiffElem(double[] arr)
{
    double maxElem = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > maxElem) maxElem = arr[i];
    }
    return maxElem;
}

double MinDiffElem(double[] arr)
{
    double minElem = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < minElem) minElem = arr[i];
    }
    return minElem;
}

double[] array = CreateArrayRndDouble(5, 1, 100);
PrintArray(array);
double maxDiffElem = MaxDiffElem(array);
double minDiffElem = MinDiffElem(array);
double difference = maxDiffElem - minDiffElem;
Console.WriteLine(@$"Разница между максимальным и минимальным элементами массива равна:
 {Math.Round(difference, 2)}");