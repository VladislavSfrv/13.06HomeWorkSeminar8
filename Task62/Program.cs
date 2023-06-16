// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:

int[,] MatrixSpiralCreate(int size)
{
    int[,] matrix = new int[size, size];
    int num = 1;
    int i = 0, j = 0;
    while(num <= size * size)
    {
        matrix[i, j] = num;
        if (i <= j + 1 && i + j < size - 1)
        ++j;
        else if (i < j && i + j >= size - 1)
        ++i;
        else if (i >= j && i + j > size - 1)
        --j;
        else
        --i;
        ++num;
    }
    return matrix;
}

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

int[,] matrix = MatrixSpiralCreate(4);
PrintMatrix(matrix);