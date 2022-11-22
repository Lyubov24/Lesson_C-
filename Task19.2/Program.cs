// Задача 19. Напишите программу, которая принимает на вход пятизначное число
// и проверяет, является ли оно палиндромом.
// Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное  число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 0)
{
    Console.WriteLine("Введены некорректные данные");
}
else
{
    void Pol5Digit(int num)
    {
        int current = num / 1000;
        if (current / 100 == 0)
        {
            if ((num / 10000) == (num % 10) && (current % 10) == (num % 100))
            {
                Console.WriteLine($"{num} -> Да");
            }
            else Console.WriteLine($"{num} -> Нет");
        }
        else Console.WriteLine("Введены некорректные данные");

    }
    Pol5Digit(number);
}


// НЕ ДОРАБОТАНА