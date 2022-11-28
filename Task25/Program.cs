// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

if (b <= 0)
{
    Console.WriteLine("Введено ненатуральное число B");
}

int Exponentiation(int c, int d)
{
    int result = 1;
    for (int i = 1; i <= d; i++)
    {
        result = c * result;
    }

    return result;
}

int exponentiation = Exponentiation(a, b);
Console.WriteLine($"Число {a} в степени {b} равно -> {exponentiation}");
