//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.WriteLine("Введите количество строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
int[,] matrix1 = new int[rows1, columns1];

Console.WriteLine("Введите количество строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
int[,] matrix2 = new int[rows2, columns2];

int[,] array2D1 = CreateMatrixRndInt1(rows1, columns1, 1, 9);
PrintMatrix1(array2D1);
Console.WriteLine();
int[,] array2D2 = CreateMatrixRndInt2(rows2, columns2, 1, 9);
PrintMatrix2(array2D2);


int[,] CreateMatrixRndInt1(int rows1, int columns1, int min, int max) 
{
    int[,] matrix1 = new int[rows1, columns1]; 
    Random rnd = new Random(); 

    for (int i = 0; i < matrix1.GetLength(0); i++) 
    {
        for (int j = 0; j < matrix1.GetLength(1); j++) 
        {
            matrix1[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix1; 
}


void PrintMatrix1(int[,] matrix1)       
{
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix1.GetLength(1); j++)
        {
            if (j < matrix1.GetLength(1) - 1) Console.Write($"{matrix1[i, j],3}, "); 
            else Console.Write($"{matrix1[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}

int[,] CreateMatrixRndInt2(int rows2, int columns2, int min, int max) 
{
    int[,] matrix2 = new int[rows2, columns2]; 
    Random rnd = new Random(); 

    for (int i = 0; i < matrix2.GetLength(0); i++) 
        {
        for (int j = 0; j < matrix2.GetLength(1); j++) 
        {
            matrix2[i, j] = rnd.Next(min, max + 1);
        }

    }
    return matrix2;
}


void PrintMatrix2(int[,] matrix2)      
{
    for (int i = 0; i < matrix2.GetLength(0); i++)
    {
        Console.Write("|");
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            if (j < matrix2.GetLength(1) - 1) Console.Write($"{matrix2[i, j],3}, "); 
            else Console.Write($"{matrix2[i, j],3} ");
        }
        Console.WriteLine("|");
    }
}


if (matrix1.GetLength(0) != matrix2.GetLength(1))
{
    Console.WriteLine(" Нельзя перемножить ");
    return;
}

int[,] resultMatrix = new int[rows1, columns2];

int[,] MultiplyMatrix(int[,] martrix1, int[,] martrix2, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < martrix1.GetLength(1); k++)
      {
        sum += martrix1[i,k] * martrix2[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
  return resultMatrix;
}


void WriteArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      Console.Write(array[i,j] + " ");
    }
    Console.WriteLine();
  }
}
MultiplyMatrix(array2D1, array2D2, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
WriteArray(resultMatrix);

