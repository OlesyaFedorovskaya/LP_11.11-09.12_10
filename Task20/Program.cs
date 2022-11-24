// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.Write("Введите точку XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите точку YB: ");
int yb = Convert.ToInt32(Console.ReadLine());

double Distance(int xc, int yc, int xd, int yd)
{
    double xe = (xc - xd) * (xc - xd);
    double ye = (yc - yd) * (yc - yd);
    double result = Math.Sqrt(xe + ye);
    return result;
}

double res = Distance(xa, ya, xb, yb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);