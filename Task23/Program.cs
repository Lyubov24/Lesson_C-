// Задача 23. Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

int n = -1;
while (n < 1)
{
    Console.WriteLine("Введите число: ");
    n = Convert.ToInt32(Console.ReadLine());
    if (n < 1) Console.WriteLine("Введены неверные данные");
}

void Square(int n1) 
{
    for (int i = 1; i <= n1; i ++)  
    {
        Console.WriteLine($"{i} | {i * i * i}");
    }
}
Square(n); 