// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
//наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5}, ");
            else Console.Write($"{matrix[i, j],5}");
        }
        Console.WriteLine();
    }
}

int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)


{
    int[,] matrix = new int[rows, columns];
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

int SumRowsMatrix(int[,] matrix)
{
    int sum = 0;
    int[] arr = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        arr[i] = sum;
        sum = 0;
    }

    int min = arr[0];
    int minRows = 1;
    for (int i = 0; i < arr.Length; i++)
    {
        if(min > arr[i]) minRows = i + 1;
    }
    return minRows;
}

bool MatrixIsSquare(int[,] matrix)
{
    return matrix.GetLength(0) == matrix.GetLength(1);
}

int[,] matrix = CreateMatrixRndInt(4, 4, 0, 10);
bool matrixSquare = MatrixIsSquare(matrix);
if(matrixSquare) 
{
    PrintMatrix(matrix);
    Console.WriteLine();
    int result = SumRowsMatrix(matrix);
    Console.WriteLine($"Номер строки с наименьшей суммой элементов -> {result}.");
}
else 
{
    Console.WriteLine("Матрица не прямоугольная.");
}
