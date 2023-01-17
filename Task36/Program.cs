// Задача 36: Напишите программу реализующую методы формирования массива, заполненного случайными числами и подсчета суммы элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


using static System.Console;

WriteLine("Введите размер массива, его минимальное и максимальное значение через пробел или через дефис.");

string [] parametras = ReadLine().Split(new char []{' ', '-'}, StringSplitOptions.RemoveEmptyEntries);


int []arr = GetAndPrintArray (int.Parse(parametras[0]), int.Parse(parametras[1]), int.Parse(parametras[2]));
WriteLine();
int result = SumOddNumbers(arr);

WriteLine($"Сумма элементов стоящих на нечетных позициях равна {result}");


int[] GetAndPrintArray (int size, int minValue, int maxValue)
{
    int [] newArray = new int [size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(minValue, maxValue);
        Write($"{newArray[i]} ");
    }

    return newArray;
}

int SumOddNumbers (int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0) sum += array[i+1];
    }

    return sum;
}