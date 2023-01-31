// Задача 66: Напишите программу, которая реализует рекурсивный метод нахождения суммы натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;



WriteLine ("Введите два числа через пробел");
int[] Parameters = Array.ConvertAll(ReadLine().Split(new string[] { " ", ", ", ";" }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);


WriteLine(GetNumbers(Parameters[0], Parameters[1]));


int GetNumbers(int numOne, int numTwo)
{
    if (numOne == numTwo) return numOne;

    else if (numOne < numTwo)
    {
        return (numOne + GetNumbers(numOne + 1, numTwo));
    }
    else 
    {
        return (numOne + GetNumbers(numOne - 1, numTwo));
    }
}
