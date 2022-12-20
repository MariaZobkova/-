using static System.Console;

WriteLine("Введите число: ");

int number = Convert.ToInt32(ReadLine()!);

int a = (number/100);
int b = (a%10);


if (number <= 99)
{
    WriteLine("Третьей цифры числа нет");
}
else
{
    WriteLine(b);
}

