// Задача 68: Напишите программу реализующую метод вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


using static System.Console;


WriteLine ("Введите два положительных целых числа через пробел");
int[] Parameters = Array.ConvertAll(ReadLine().Split(new string[] { " ", ", ", ";" }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);


WriteLine(GetNumbers(Parameters[0], Parameters[1]));


int GetNumbers(int numOne, int numTwo)
{

    if (numOne == 0)
    {
        return numTwo + 1;
    }
    else if (numOne > 0 && numTwo == 0)
    {
        return GetNumbers(numOne - 1, 1);
    }
    else 
    {
        return GetNumbers(numOne - 1, GetNumbers(numOne, numTwo -1));
    }
}

