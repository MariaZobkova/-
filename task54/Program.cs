// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

using static System.Console;

WriteLine("Введите размер матрицы ее минимальное и максимальное значение через пробел");


int[] intParameters = Array.ConvertAll(ReadLine().Split(new string[] { " ", ", ", ";" }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
int[,] newMatrix = GetMatrix(intParameters[0], intParameters[1], intParameters[2], intParameters[3]);

PrintMatrixArray(newMatrix);
WriteLine();

SortMatrix(newMatrix);
PrintMatrixArray(newMatrix);



int[,] GetMatrix(int rows, int colomns, int minValue, int maxValue)
{
    int[,] matrix = new int[rows, colomns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            matrix[i, j] = new Random().Next(minValue, maxValue);
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

void SortMatrix(int[,] array)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int a = 0; a < array.GetLength(1) - 1; a++)
            {
                if (array[j, a] < array[j, a + 1])
                {
                    int temp = array[j, a];
                    array[j, a] = array[j, a + 1];
                    array[j, a + 1] = temp;

                }


            }

        }
    }

}




