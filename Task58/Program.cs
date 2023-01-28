// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

using static System.Console;

WriteLine("Введите размер первой матрицы через пробел");


int[] intParametersOne = Array.ConvertAll(ReadLine().Split(new string[] { " ", ", ", ";" }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);

int[,] MatrixOne = GetMatrix(intParametersOne[0], intParametersOne[1]);

WriteLine("Введите размер второй матрицы через пробел");

int[] intParametersTwo = Array.ConvertAll(ReadLine().Split(new string[] { " ", ", ", ";" }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);

int[,] MatrixTwo = GetMatrix(intParametersTwo[0], intParametersTwo[1]);

PrintMatrixArray(MatrixOne);
WriteLine();
PrintMatrixArray(MatrixTwo);
WriteLine();


MyltiplyMatrices(MatrixOne, MatrixTwo);







int[,] GetMatrix(int rows, int colomns)
{
    int[,] matrix = new int[rows, colomns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            matrix[i, j] = new Random().Next(2, 5);
        }
    }

    return matrix;
}

void PrintMatrixArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],4} ");
        }
        WriteLine();
    }
}

void MyltiplyMatrices(int[,] array, int[,] inArray)

{
    if (array.GetLength(1) != inArray.GetLength(0))
    {
        WriteLine ("Умножение матриц возможно только при условии что количество столбцов первой матрицы равно количеству строк второй матрицы");
    }
    else
    {
    int[,] result = new int[array.GetLength(0), inArray.GetLength(1)];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            result [i, j] = 0;

            for (int a = 0; a < array.GetLength(1); a++)
            {
                result [i, j] += array[i, a] * inArray[a, j];
            }
        }
    }
    PrintMatrixArray(result);

    }
    
    
}



