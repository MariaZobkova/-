// Задача 38: Напишите программу реализующую методы формирования массива, заполненного случайными вещественными числами и вычисления разницы между максимальным и минимальным элементов массива.

// [3,3 7,1 22,5 2,2 78,2] -> 76

using static System.Console;

WriteLine("Введите размер массива" );

bool isParse = int.TryParse(ReadLine(), out int size);
if (!isParse)
{
    WriteLine("Введено не число");
    return;
}

int [] arr = GetAndPrintArray (size);
WriteLine();
int result = DifferenceMaxMin(arr);
WriteLine($"Разность максимального и минимального элементов массива равна {result}" );

int[] GetAndPrintArray (int size)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(1, 100);
        Write($"{newArray[i]} ");
    }

    return newArray;
}

int DifferenceMaxMin (int [] array)
{
 
    int max = array[0];
    int min = max;
    

    for (int i = 0; i < array.Length; i++)
   
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
   
    int diff = max - min;
    return diff;

}   