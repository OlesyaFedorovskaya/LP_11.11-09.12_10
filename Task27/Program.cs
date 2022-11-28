// Задача 27: Напишите программу, которая 
// принимает на вход число и 
// выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("Введены неверные данные");
}

int Sum(int num)
{
    int result = 0;
    while (num > 0)
    {
        result = result + num % 10;
        num = num / 10;
    }
    return result;
}

int sum = Sum(number);
Console.WriteLine($"Сумма цифр числа {number} = {sum}");