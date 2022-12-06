// Задача 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1,1) и т. д.)

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

int SumDiagonalMatrix(int[,] matrix)
{
    int sum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
      for (int j = 0; j < matrix.GetLength(1); j++)
      {
        if (i == j) sum += matrix[i, j];
      }  
    }
    return sum;
}
int[,] array2D = CreateMatrixRndInt(5, 5, 1, 9);
PrintMatrix(array2D);
Console.WriteLine();
int sumDiagonalMatrix = SumDiagonalMatrix(array2D);
Console.WriteLine($"Сумма элементов, находящихся на главной диагонали = {sumDiagonalMatrix}");