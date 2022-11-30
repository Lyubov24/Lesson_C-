// Задача 39: Напишите программу, которая перевернет одномерный массив (последний элемент будет на первом месте, а первый на последнем и т.д.)
//[1 2 3 4 5]->[5 4 3 2 1]

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

// Array.Reverse(array); встроенный метод

void ReverseArray(int[] array)
{
    for (int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i]; //задаем новую временную переменную
        array[i] = array[array.Length - 1 - i];
        array[array.Length - 1 - i] = temp;
    }
}

int[] array = CeateArrayRndInt(5, 1, 9);
PrintArray(array);
Console.Write(" -> ");
ReverseArray(array);
PrintArray(array);