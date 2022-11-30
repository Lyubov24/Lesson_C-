//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

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
int[] array = CeateArrayRndInt(6, - 10, 10);
PrintArray(array);


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


int CountElement(int[] array) // метод суммирующий числа, стоящие на нечетных позициях
{ 
    int countElement = 0; 
    for (int i = 1; i < array.Length; i += 2) 
    { 
        countElement += array[i]; 
    } 
    return countElement; 
} 
 
int countElement = CountElement(array); 
Console.Write(countElement);    



