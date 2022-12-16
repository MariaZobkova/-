using static System.Console;

WriteLine("Введите число: ");

int a = Convert.ToInt32(ReadLine());

if ((a % 2)==0)
{
    WriteLine($"Число {a} четное");
}
else
{
    WriteLine($"Число {a} нечетное");
}