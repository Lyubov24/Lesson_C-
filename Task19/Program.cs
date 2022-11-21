﻿// Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное  число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 0)
{
    Console.WriteLine("Введены некорректные данные");
}
else
{
    int a = num / 1000;
    if (a / 100 == 0)
    {
        int num1 = num % 10;
        int num11 = num / 10000;
        if (num1 == num11)
        {
            int num2 = num / 10 % 10;
            int num22 = num / 1000 % 10;
            if (num2 == num22)

                Console.WriteLine($"{num} -> да");
            else
            {
                Console.WriteLine("Введены некорректные данные");
            }
        }
        else Console.WriteLine($"{num} -> нет");
    }

    else
    {
        Console.WriteLine("Введены некорректные данные");
    }
}
