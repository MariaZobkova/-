//Задача 29: Напишите программу, реализующую метод, который формирует массив случайных целых чисел из 8 элементов и выводит их на экран.

using static System.Console;

int[] arr = GetArray(8);
PrintArray (arr);

int[] GetArray (int size)
{
    int [] array = new int[size];
    {
        for (int i = 0; i < array.Length; i++)
        {
            array [i] = new Random().Next();

        }
    }
    return array;
}

void PrintArray (int [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]} ");
    }
}
