// 14. Напишите программу, которая 
// принимает на вход число и 
// проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

Console.WriteLine("Введите целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Кратно ли число одновременно 7 и 23: ");

Console.WriteLine(Multiplicity(number) ? "Да" : "Нет");

bool Multiplicity(int num1)
{
    return (num1 % 7 == 0) && (num1 % 23 == 0);
}