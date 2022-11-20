// Задача 22. Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1, 4.

int n = -1;
while (n < 1)
{
    Console.WriteLine("Введите число: ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Введены неверные данные");
}

void Square(int n1)  // невозвращающий метод
{
    for (int i = 1; i <= n1; i ++)  //тело метода
    {
        Console.WriteLine($"{i} | {i * i}");
    }
}
Square(n); // обращение к методу

