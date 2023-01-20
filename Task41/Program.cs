// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

using static System.Console;


WriteLine("Введите размер массива вводимых чисел" );

int M = int.Parse(ReadLine()!);

int[] arr = FillArray (M);



int Sum = PositiveNumbersInArray(arr);
WriteLine($"Количество чисел в массиве [{String.Join(", ", arr)}] больше 0 равно {Sum}" );

int[] FillArray (int size)
{
    int[] newArray = new int [size];

    WriteLine("Введите числа в массиве" );
    
    for (int i = 0; i < size; i++)
    {
        newArray[i] = int.Parse(ReadLine()!);
        
    }

    return newArray;
}

int PositiveNumbersInArray (int[] array)
{
    int result = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result++;
        
    }

    return result;
}
