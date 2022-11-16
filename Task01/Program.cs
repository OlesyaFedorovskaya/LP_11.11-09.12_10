// Напишите программу, которая 
//на вход принимает 2 числа
//проверяет, является ли первое число квадратом второго

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a == b * b)
{
    Console.Write("Результат: ");
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}