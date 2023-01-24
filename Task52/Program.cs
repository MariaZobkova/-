// Задача 52. Напишите программу реализующую методы, формирования двумерного массива и массива средних арифметических значений каждого столбца.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using static System.Console;

WriteLine("Введите размер матрицы ее минимальное и максимальное значение через пробел");


int[] intParameters = Array.ConvertAll(ReadLine().Split(new string[]{" ", ", ", ";"}, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);
int[,] newMatrix = GetMatrix(intParameters[0], intParameters[1], intParameters[2], intParameters[3]);

PrintMatrixArray(newMatrix);
WriteLine();

double [] avg = AverageColomnsMatrix(newMatrix);
WriteLine($"({String.Join(", ", avg)})");





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

double [] AverageColomnsMatrix (int [,] array)
{
    double [] result = new double [array.GetLength(1)];
    
   
    for (int a = 0; a < array.GetLength(1); a++)
   
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            int j = a;
            result[a] += array[i,j]; 
            
        }

        result[a] = result[a]/array.GetLength(0);
    }
    return result;   
   
}