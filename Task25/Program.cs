// Задача 25: Напишите цикл, который 
// принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int B = Convert.ToInt32(Console.ReadLine());

if (B <= 0)
{
    Console.WriteLine("Введено неверное число B");
}

else
{
    int Exponentiation(int c, int d)
    {
        int result = 1;
        for (int i = 1; i <= d; i++)
        {
            result = c * result;
        }

        return result;
    }
    int exponentiation = Exponentiation(A, B);
    Console.WriteLine($"Число {A} в степени {B} равно -> {exponentiation}");
}