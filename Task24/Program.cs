// Задача 24. Напишите программу, которая принимает на вход число (A) и выдает сумму чисел от 1 до А.


Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

int SumDigits(int num)
{
    int sum = default; // int sum = 0
    for (int i = 1; i <= num; i++)
    {
        sum = sum + i;
    }
    return sum;
}
if (number > 0)
{
    int sumDigits = SumDigits(number);
    Console.WriteLine($"Сумма чисел от 1 до {number} = {sumDigits}");
}
else Console.WriteLine("Требуется ввести натуральное число");