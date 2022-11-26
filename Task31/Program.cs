// Задача 31. Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].
// Найдите сумму  отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

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
    Console.Write("]");
}
// int[] array = CeateArrayRndInt(12, -9, 9);
// PrintArray(array);


int GetSumNegativeElem(int[] arr)     // метод для суммирования отрицательных чисел массива
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] < 0) sum += arr[i]; // sum = sum+ arr[i];
    }
    return sum;
}

int GetSumPositiveElem(int[] arr)     // метод для суммирования положительных чисел массива
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) sum += arr[i]; // sum = sum + arr[i];
    }
    return sum;
}

int[] array = CeateArrayRndInt(12, -9, 9);  // вывод результата
PrintArray(array);
Console.WriteLine();
int sumNegative = GetSumNegativeElem(array);
int sumPositive = GetSumPositiveElem (array);
Console.WriteLine($"Сумма отрицательных чисел равна {sumNegative}");
Console.WriteLine($"Сумма положительных чисел равна {sumPositive}");
