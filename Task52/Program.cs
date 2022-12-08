// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.



int[,] CreateMatrixRndInt(int rows, int colums, int min, int max) 
{
    int[,] matrix = new int[rows, colums]; 
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix.GetLength(1); j++) 
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix; 
}

void PrintMatrix(int[,] matrix)    
{

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],3}, "); 
            else Console.Write($"{matrix[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}
int[,] array2D = CreateMatrixRndInt(3, 4, 1, 10);
PrintMatrix(array2D);

double[] avgNumbers = new double[array2D.GetLength(1)];

for (int i = 0; i < array2D.GetLength(1); i++)
{
    double result = 0.0;
    for (int j = 0; j < array2D.GetLength(0); j++)
    {
        result += array2D[j, i];
    }
    avgNumbers[i] = result / array2D.GetLength(0);
}
void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1) Console.Write($"{Math.Round(array[i], 1) + "; " }");
        else Console.Write($"{Math.Round(array[i], 1) + " " }");
        
    }
   
}
 Console.WriteLine();
PrintArray(avgNumbers);

