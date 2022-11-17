// 7. Напишите программу, которая 
//принимает на вход трёхзначное число и 
//на выходе показывает последнюю цифру этого числа.
//456 -> 6
//782 -> 2
//918 -> 8

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int last = num % 10;
//int first = num % 100;
Console.Write(last);