// Задача 33: Задайте массив. Напишите программу, которая 
// определяет, присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да 


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
int[] array = CeateArrayRndInt(5,  0, 1000);  // вывод результата
PrintArray(array);

bool FindNumberArray(int[] arr, int numb)
{
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == numb) return true;
    }
    return false;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine()); 
Console.Write(FindNumberArray(array, number) == true  ? "Да" : "Нет"); // тернарный оператор