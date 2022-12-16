//Задача 53. Задайте двумерный массив. Напишите программу, которая поменяет местами первую  и последнюю строку  массива.

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
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, "); // 5 это форматирование, чтобы были ровные столбики
            else Console.Write($"{matrix[i, j],5} ");
        }
        Console.WriteLine("|");
    }
}

void ReplaseRows(int[,] matrix)
{
    
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int temp = 0; //временная переменная
        temp = matrix[0, j];
        matrix[0, j] = matrix[matrix.GetLength(0) - 1, j];
        matrix[matrix.GetLength(0) - 1, j] = temp;
    }
}

int[,] array2D = CreateMatrixRndInt(3, 4, 0, 9);
PrintMatrix(array2D);
Console.WriteLine();
ReplaseRows(array2D);
PrintMatrix(array2D);

