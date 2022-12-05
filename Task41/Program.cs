// Задача 41: Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите количество чисел: ");
int numbers = Convert.ToInt32(Console.ReadLine());


int[] PrintNumbers(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        Console.Write($"Введите {i} элемент: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

int AmountOfNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

int[] array = PrintNumbers(numbers);
Console.WriteLine($"Количество чисел больше нуля равно: {AmountOfNumbers(array)}");