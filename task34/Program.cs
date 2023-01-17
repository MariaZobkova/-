// Задача 34: Напишите программу реализующую методы формирования массива, заполненного случайными положительными трёхзначными числами, и подсчета количества чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

using static System.Console;

WriteLine("Введите размер массива" );

bool isParse = int.TryParse(ReadLine(), out int size);
if (!isParse)
{
    WriteLine("Введено не число");
    return;
}

int []arr = GetAndPrintArray (size);

WriteLine();

int evenNumber = EvenValue(arr);
WriteLine($"Количество четных элементов в массиве равно {evenNumber}");


int[] GetAndPrintArray (int size)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100, 1000);
        Write($"{newArray[i]} ");
    }

    return newArray;
}

int EvenValue (int [] array)
{
    int result = 0;

    foreach (var a in array)
    {
        if (a % 2 == 0) result++;
    }

    return result;

}