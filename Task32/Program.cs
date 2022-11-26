// Задача 32: Напишите программу замена элементов массива: положительные элементы замените на 
// соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

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

 void NegativArray(int[] arr) // метод, который печатает массив в квадратных скобках с запятыми       
{
    
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }

}


int[] array = CeateArrayRndInt(12, -9, 9);
PrintArray(array);
Console.Write("-->");
NegativArray(array);
PrintArray(array);