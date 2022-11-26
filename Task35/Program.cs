// Задача 35: Задайте одномерный массив из 123 случайных чисел. 
// Найдите количество элементов массива, значения которых лежат в 
// отрезке [10,99]. 
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 
// 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5

int[] CeateArrayRndInt(int size, int min, int max) // параметры - исходные данные метода
{
    int[] arr = new int[size]; // создание массива
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++) // заполнение массива
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr; // обращение к методу
}

void PrintArray(int[] arr) // метод, который печатает массив в квадратных скобках с запятыми       
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{arr[i]}, ");
        else Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountElement(int[] array)
{
    int count = default; // int sum = 0
    for (int i = 0; i <array.Length; i++)
    {
        if (array[i] > 9 && array[i] < 100) count++;
    }
    return count;
}
int[] array = CeateArrayRndInt(123, 0, 1000);
PrintArray(array);
int countElement = CountElement(array);
Console.Write($"Двузначных чисел в массиве {countElement}");
