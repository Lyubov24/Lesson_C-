// Задача 11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.
// 456 -> 46
// 872 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.Write($"{number} -> ");

int RemoveSecondDigit(int numb)
{
    int firstDigit = numb/100;
    int SecondDigit = numb % 10;
    int resalt = firstDigit * 10 + SecondDigit;
    return resalt;
}
 Console.Write(RemoveSecondDigit(number));