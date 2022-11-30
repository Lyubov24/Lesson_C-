//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементами массива.
//[3.5, 7.1, 22.9, 2.3, 78.5] -> 76.2

double[] CeateArrayRndDouble(int size, int min, int max)
{
    double[] arr = new double[size];
    Random rnd = new Random();

    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.NextDouble() * (max - min) + min;
    }
    return arr;
}
double[] array = CeateArrayRndDouble(5, 0, 100);
PrintArray(array);


void PrintArray(double[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        if (i < arr.Length - 1) Console.Write($"{Math.Round(arr[i],2)}, ");
        else Console.Write($"{Math.Round(arr[i],2)}");
    }
    Console.WriteLine("]");
}


double max = array[0];
double min = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max) max = array[i];

    else if (array[i] < min) min = array[i];
}

Console.Write($"Разность = {Math.Round(max - min,2)}");
