//Задача 27: Напишите программу, реализующую метод, который принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;

WriteLine ("Введите число ");
int A = int.Parse(ReadLine()!);

int sum = SumNumbers (A);
WriteLine ($"Сумма цифр в числе равна {sum} ");




int SumNumbers (int number)
{
    int result = 0;

    
    while (number > 0)
    {
        int i = number % 10;
        result += i;
        number = number/10;
        
    }

    return result;
}


