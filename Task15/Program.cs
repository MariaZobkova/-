// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

using static System.Console;

WriteLine("Введите число: ");

int a = Convert.ToInt32(ReadLine()!);

if (a == 6 || a == 7)
{
    WriteLine("Выходной");
}
else if (a >= 1 && a < 6)
{
    WriteLine("Не выходной");
}
else
{
    WriteLine("Вы ввели недопустимое значение");
}