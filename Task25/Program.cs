// Задача 25: Напишите программу, реализующую метод,который принимает на вход два числа (A и B) и возводит число A в натуральную степень B с использованием цикла.
// В задаче не использвать стандартный метод Pow!
// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

using static System.Console;

WriteLine ("Введите число ");
int A = int.Parse(ReadLine()!);

WriteLine ("Введите степень числа ");
int B = int.Parse(ReadLine()!);


int expAB = Exp(A, B);
WriteLine($"Число в указаной степени равно {expAB} ");



int Exp (int i, int j)
{
    int result = 1;

    if (j < 0) return 0;

    
    for (int g = 0; g < j; g++)
    {
  
       result *= i;
        
    }

    return result;
}

