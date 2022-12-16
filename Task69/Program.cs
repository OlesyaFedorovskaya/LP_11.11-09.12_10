// Задача 69: Напишите программу, которая 
// на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

Console.WriteLine("Введите число A: ");
int numbA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int numbB = Convert.ToInt32(Console.ReadLine());

int Exponentiation(int c, int d)
{
    return d == 0 ? 1 : Exponentiation(c, d - 1) * c;
}

Console.WriteLine(Exponentiation(numbA, numbB));


// int Exponentiation(int c, int d)
// {
//     if(d == 0) return 1;
//       return Exponentiation(c, d - 1) * c;
// }

// int Exponentiation(int c, int d)
// {
//     if (d == 0) return 1;
//     else if (n % 2 == 0) return Exponentiation(c * c, d / 2);
//     else return Exponentiation(c, d - 1) * c;
// }