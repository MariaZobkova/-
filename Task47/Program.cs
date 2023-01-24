// Задача 47. Напишите программу реализующую метод, который возвращает массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

using static System.Console;

WriteLine("Введите размер матрицы ее минимальное и максимальное значение через пробел");

string[] parameters = ReadLine().Split(new string[]{" ", ", ", ";"}, StringSplitOptions.RemoveEmptyEntries);


double[,] newMatrix = GetMatrixDouble(int.Parse(parameters[0]), int.Parse(parameters[1]), Convert.ToDouble(parameters[2]), Convert.ToDouble(parameters[3]));

PrintMatrixArray(newMatrix);





double [,] GetMatrixDouble (int rows, int colomns, double minValue, double maxValue)
{
    double [,] matrix = new double [rows, colomns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colomns; j++)
        {
            matrix [i, j] = new Random().NextDouble() * (maxValue - minValue) + minValue;
        }
    }

    return matrix;
}

void PrintMatrixArray(double[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j],8 :f2} ");  
        }
        WriteLine();
    }
}


