// Задача 10: Напишите программу, которая 
// принимает на вход трёхзначное число и 
//на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SecondDigit(int numb)
{
    int firstDigit = numb % 100;
    int secondDigit = firstDigit / 10;
    return secondDigit;
}

// или

//int SecondDigit(int numb)
//{
    //int firstDigit = numb % 100;
    //int thirdDigit = numb % 10;
    //int result = (firstDigit - thirdDigit) / 10;
    //return result;
//}

Console.WriteLine("Вторая цифра введенного числа будет: ");
Console.WriteLine($"{SecondDigit(number)}");