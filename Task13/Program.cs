//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//Выполнить с помощью числовых операций (целочисленное деление, остаток от деления).
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.WriteLine("Введите  число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 999)
{
    do
    {
        number = number / 10;
    }
    while (number > 999);
    int result = number % 10;   
}

if (number > 99)
{
    int result = number % 10;

    Console.WriteLine(result);
}
if (number < 100)
 Console.WriteLine("третьей цифры нет");
 
 