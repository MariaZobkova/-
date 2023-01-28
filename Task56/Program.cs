// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

using static System.Console;

WriteLine("Введите размер матрицы ее минимальное и максимальное значение через пробел");


int[] intParameters = Array.ConvertAll(ReadLine().Split(new string[] { " ", ", ", ";" }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
int[,] newMatrix = GetMatrix(intParameters[0], intParameters[1], intParameters[2], intParameters[3]);

PrintMatrixArray(newMatrix);
WriteLine();


int newnewMatrix = SumElementsRows(newMatrix);
WriteLine($"{newnewMatrix} строкa");




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

int SumElementsRows(int[,] array)
{
    int result = 0;
    int[] resultArray = new int[array.GetLength(0)];

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                int a = i;
                resultArray[a] += array[i, j];
                a++;
            }
        }

    



    for (int a = 0; a < resultArray.Length; a++)
    {
        int min = resultArray[0];

        if (resultArray[a] < min)
        {
            min = resultArray[a];
            result = a;
        }
    }

    return result;

}



