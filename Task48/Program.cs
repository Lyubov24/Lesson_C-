// Задача 48. Задайте двумерный массив размером mХn, где каждый элемент массива находится по формуле: Amn = m + n. 
//Выведите полученный массив на экран.
// m = 3, n = 4.
// 0 1 2 3
// 1 2 3 4
// 2 3 4 5

int[,] CreateMatrix(int rows, int colums, int min, int max) // параметры - исходные данные метода
{
    int[,] matrix = new int[rows, colums]; // создание двумерного массива массива
    
    for (int i = 0; i < matrix.GetLength(0); i++) // заполнение массива, во внешнем цикле проходим по строкам . 0 индекс указывающий на строки
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // во внутреннем цикле проходим по столбцам. 1 индекс указывающий на столбцы
        {
            matrix[i, j] = i + j; // присваем значения ячейкам
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
int[,] array2D = CreateMatrix(3, 4, 10, 10);
PrintMatrix(array2D);

