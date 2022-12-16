// Задача 57. Составить частотный словарь элементов массива. 
// Частотный словарь содержит инфомацию о том, сколько раз встречается элемент входных данных.

int[,] CreateMatrixRndInt(int rows, int colums, int min, int max) // параметры - исходные данные метода
{
    int[,] matrix = new int[rows, colums]; // создание двумерного массива массива
    Random rnd = new Random(); //случайные числа

    for (int i = 0; i < matrix.GetLength(0); i++) // заполнение массива, во внешнем цикле проходим по строкам . 0 индекс указывающий на строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // во внутреннем цикле проходим по столбцам. 1 индекс указывающий на столбцы
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix; // обращение к методу
}


void PrintMatrix(int[,] matrix) // метод, который печатает массив в квадратных скобках с запятыми       
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 3}, "); 
            else Console.Write($"{matrix[i, j], 3} ");
        }
        Console.WriteLine("|");
    }
}

int[] MatrixToArray(int[,] matrix)
{
    int[] arr = new int[matrix.Length];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
     for (int j = 0; j < matrix.GetLength(1); j++)
     {
        arr[k++] = matrix[i, j];
     }   
    }
    return arr;
}
void PrintArray(int[] arr)
{
    Console.Write("\n[");
    for (int i = 0; i < arr.Length; i++)
    {
     Console.Write($"  {arr[i]}");
     Console.Write((i < arr.Length - 1) ? "," : string.Empty);
    }
    Console.WriteLine("]\n");
}

void CountValue(int[] arr)
{
    int count = 1;
    int num = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if(arr[i] == num) count++;
        else
        {
            Console.WriteLine($"{num} встречается {count} раз.");
            count = 1;
            num = arr[i];
        }
    }
    Console.WriteLine($"{num} встречается {count} раз.");
}

int[,] array2D = CreateMatrixRndInt(5, 5, 1, 9);
PrintMatrix(array2D);
int[] array = MatrixToArray(array2D);
Array.Sort(array); //сортировка массива по возрастанию
PrintArray(array); //распечатка сортировки
Console.WriteLine();
CountValue(array); // вывод  последнего метода