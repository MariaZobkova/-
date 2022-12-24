using static System.Console;

WriteLine("Введите пятизначное число: ");

bool isParse = int.TryParse(ReadLine(), out int number);
if (!isParse)
{
    WriteLine("Введено не число");
    return;
}

int a = (number/10000);
int b = (number/1000%10);
int c = (number/10%10);
int d = (number%10);


if (a == d && b == c)
{
    WriteLine("Полиндром");
}
else
{
    WriteLine("Не полиндром");
}
