// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateToThreeDimensionalMatrix(int row, int columns, int depth, int min, int max)
{
    int[,,] matrix = new int[row, columns, depth];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(2); n++)
            {
            matrix[i, j, n] = rnd.Next(min, max + 1);
            }
        }
    }
    return matrix;
}

void ToPrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int n = 0; n < matrix.GetLength(2); n++)
            {
                Console.Write($" {matrix[i, j, n]} {(i, j, n) }");
            }
        }
        Console.WriteLine();
    }
}

int[,,] matrix = CreateToThreeDimensionalMatrix(2, 2, 2, 10, 99);
ToPrintMatrix(matrix);