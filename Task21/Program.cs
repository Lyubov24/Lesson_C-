// Задача 21. Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
//       A (3,6,8); B (2,1,-7), -> 15.84
//       A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите координаты точки A ");
Console.Write("xA: ");
double xa = Convert.ToInt32(Console.ReadLine());
Console.Write("yA: ");
double ya = Convert.ToInt32(Console.ReadLine());
Console.Write("zA: ");
double za = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты  точки B ");
Console.Write("xB: ");
double xb = Convert.ToInt32(Console.ReadLine());
Console.Write("yB: ");
double yb = Convert.ToInt32(Console.ReadLine());
Console.Write("zB: ");
double zb = Convert.ToInt32(Console.ReadLine());

double Distance(double xa, double ya, double xb, double yb, double za, double zb)
{
  double xc = (xa - xb) * (xa - xb); 
  double yc = (ya - yb) * (ya - yb);
  double zc = (za - zb) * (za - zb);
  double result = Math.Sqrt(xc + yc + zc);
  return result;
}
double res = Distance(xa, ya, xb, yb, za, zb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);
