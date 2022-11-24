// Задача 21. Напишите программу, которая 
// принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату точки XA: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки YA: ");
int ya = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки ZA: ");
int za = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки XB: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки YB: ");
int yb = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату точки ZB: ");
int zb = Convert.ToInt32(Console.ReadLine());

double Distance(int xc, int yc, int zc, int xd, int yd, int zd)
{
   double xe = (xd - xc) * (xd - xc);
   double ye = (yd - yc) * (yd - yc);
   double ze = (zc - zd) * (zc - zd);
   double result = Math.Sqrt(xe + ye + ze);
   return result;
}

double res = Distance(xa, ya, za, xb, yb, zb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);

