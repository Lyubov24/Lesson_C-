// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1, 7 -> такого элемента в массиве нет

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

Console.WriteLine("Введите номер столбца: ");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите номер строки: ");
int j = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrixRndInt(5, 5, 1, 10);
PrintMatrix(matrix);

if (i < 0 || j < 0) Console.WriteLine("Введены некорректные данные");
else
{
if (i < matrix.GetLength(0) && j < matrix.GetLength(1)) Console.Write($" [{i};{j}] -> {matrix[i, j]}");
else Console.WriteLine($"[{i};{j}] -> такого числа в массиве нет");
}
