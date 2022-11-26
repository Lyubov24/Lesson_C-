// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


int[] CeateArrayRndInt(int size, int min, int max) 
{
    int[] arr = new int[size]; 
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++) 
    {
        arr[i] = rnd.Next(min, max + 1);
    }
    return arr; 
}

void PrintArray(int[] arr)        
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
    int count = default; 
    for (int i = 0; i <array.Length; i++)
    { 
        if (array[i] % 2 == 0)  count++;
    }
    return count;
}

int[] array = CeateArrayRndInt(10,  100, 1000);  
PrintArray(array);

int countElement = CountElement(array);
Console.WriteLine($"количество чётных чисел в массиве -> {countElement} ");