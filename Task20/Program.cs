// Задача 20. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// А(3, 6);  В(2, 1) -> 5,09
// A(7,-5);  B(1,-1) -> 7,21


// int n = 3456
// double res = Math.Sqrt(n)     -  квадратный корень

// double n = 5.098897;
// double nRound = Math.Round(n, 2, MidpointRounding.ToZero);          -  округление


Console.WriteLine("Введите координаты точки A ");
Console.Write("xA: ");
double xa = Convert.ToInt32(Console.ReadLine());
Console.Write("xA: ");
double ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты  точки B ");
Console.Write("xB: ");
double xb = Convert.ToInt32(Console.ReadLine());
Console.Write("yB: ");
double yb = Convert.ToInt32(Console.ReadLine());

double Distance(double xa, double ya, double xb, double yb)
{
  double xc = (xa - xb) * (xa - xb); 
  double yc = (ya - yb) * (ya - yb);
  double result = Math.Sqrt(xc + yc);
  return result;
}
double res = Distance(xa, ya, xb, yb);
double resRound = Math.Round(res, 2, MidpointRounding.ToZero);
Console.WriteLine(resRound);