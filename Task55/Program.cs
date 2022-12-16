// Задача 55. Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
// В случае, если это невозможно, программа должна вывести сообщение для пользователя.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j], 5}, "); // 5 это форматирование, чтобы были ровные столбики
            else Console.Write($"{matrix[i, j], 5} ");
        }
        Console.WriteLine("|");
    }
}

int [,] CreateModifiedMatrix(int[,] matrix)
{
    int[,] matrix2 = new int[matrix.GetLength(0), matrix.GetLength(1)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
       for (int j = 0; j <matrix.GetLength(1); j++)
       {
        matrix2[i, j] = matrix [j, i];
       } 
    }
    return matrix2;
}

int[,] matrix = CreateMatrixRndInt(4, 5, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();

if (matrix.GetLength(0) != matrix.GetLength(1))
{
    Console.WriteLine("Замена невозможна.");

}
else
{
    int[,] matrix2 = CreateModifiedMatrix(matrix);
    PrintMatrix(matrix2);
}
