// Задача 65: Задайте значения M и N. 
// Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.

Console.WriteLine("Введите первое натуральное число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

NaturalNumbers(number1, number2);

void NaturalNumbers(int num1, int num2)
{
    if (num1 > num2) 
    {
        //Console.Write($"{num2} "); // от 6 до 1
        NaturalNumbers(num1, num2 + 1);
        Console.Write($"{num2} "); // от 1 до 6
    }
    if (num1 < num2) 
    {
        Console.Write($"{num1} "); // от 6 до 1
        NaturalNumbers(num1 + 1, num2);
        //Console.Write($"{num1} "); // от 1 до 6
    }
    if (num1 == num2) 
        Console.Write($"{num1} "); // от 6 до 1
      //Console.Write($"{num} "); // от 1 до 6
    
}