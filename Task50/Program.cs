// Задача 50. Напишите программу реализующую метод,принимающий позиции элемента в двумерном массиве, и возвращающий значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1;7 -> такого элемента в массиве нет
// 1;1 -> 9

using static System.Console;

WriteLine("Введите размер матрицы ее минимальное и максимальное значение через пробел");


int[] intParameters = Array.ConvertAll(ReadLine().Split(new string[]{" ", ", ", ";"}, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
int[,] newMatrix = GetMatrix(intParameters[0], intParameters[1], intParameters[2], intParameters[3]);

PrintMatrixArray(newMatrix);
WriteLine();
WriteLine("Введите позицию искомого элемента через пробел");
int[] intParam = Array.ConvertAll(ReadLine().Split(new string[]{" ", ", ", ";"}, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
string finalResult = FindElementMatrix(newMatrix, intParam[0], intParam[1]);
WriteLine(finalResult);



int [,] GetMatrix (int rows, int colomns, int minValue, int maxValue)
{
    int [,] matrix = new int [rows, colomns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            matrix [i, j] = new Random().Next(maxValue - minValue);
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

string FindElementMatrix (int [,] array, int a, int b)
{
    string result = string.Empty;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (a < array.GetLength(0) && b < array.GetLength(1)) result = "Значение искомого элемента равно " + Convert.ToString(array[a,b]);
            else result = "Такого элемента нет";
        }

    }
    return result;
}