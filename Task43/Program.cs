//Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("введите значение b1");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение k1");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение b2");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("введите значение k2");
double k2 = Convert.ToDouble(Console.ReadLine());

double FindX(double B1, double B2, double K1, double K2)
{
double x = (B2 - B1)/(K1 - K2);  
return x;
}
double resultX = FindX(b1,k1,b2,k2);   

double FindY(double B2, double K2, double resultX)
{
double y = K2 * resultX + B2; 
return y;
}

double numberX = FindX(b1, b2, k1, k2);
double numberY = FindY(b2, k2, numberX);
Console.WriteLine($"Точка пересечения прямых ({Math.Round(numberX,1)}; {Math.Round(numberY,1)})");

