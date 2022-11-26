// Задача 37: Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний 
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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


int[] NewArray(int[] arr) // метод возвращающий массив
{
    int newArraySize = arr.Length / 2;
    if (arr.Length % 2 == 1) newArraySize += 1;
    int[] newArray = new int[newArraySize];
    for (int i = 0; i < arr.Length / 2; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length - 1 - i];
    }
    if (arr.Length % 2 == 1) newArray[newArraySize - 1] = arr[arr.Length / 2]; //перемещение среднего элемента в конец массива
    return newArray;
}


int[] array = CeateArrayRndInt(6, 0, 10);  // вывод результата
PrintArray(array);
int[] newArr = NewArray(array);
PrintArray(newArr);