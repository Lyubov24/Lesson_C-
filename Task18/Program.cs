// Задача 18. Напишите программу, которая по заданному номеру четверти,
// показывает диапозон возможных координат точек в этой четверти (x и y).


Console.WriteLine("Введите номер четверти ");
int quarter = Convert.ToInt32(Console.ReadLine());

string Range(int quarter1)
{
    if (quarter1 == 1) return "x > 0 и y > 0";
    if (quarter1 == 2) return "x < 0 и y > 0";
    if (quarter1 == 3) return "x < 0 и y < 0";
    if (quarter1 == 4) return "x > 0 и y < 0";
    return "Указан неверный номер четверти";
}
string range = Range(quarter);
Console.WriteLine(range);

