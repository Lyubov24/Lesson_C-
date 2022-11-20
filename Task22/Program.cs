// Задача 22. Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

Console.WriteLine("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

void Square(int n)  // метод
{
    for (int i = 1; i <= n; i ++)  //тело метода
    {
        Console.WriteLine($"{i} -> {i * i}");
    }
}
Square(num); // обращение к методу

