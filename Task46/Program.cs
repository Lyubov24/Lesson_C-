// Задача 46. Задайте двумерный массив размером mХn, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1   4  8   19
// 5  -2  33  -2
// 77  3  8    1

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
int[,] array2D = CreateMatrixRndInt(3, 4, -100, 100);
PrintMatrix(array2D);
