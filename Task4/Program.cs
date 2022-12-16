using static System.Console;

WriteLine("Введите первое число: ");

int a = Convert.ToInt32(ReadLine());

WriteLine("Введите второе число: ");

int b = Convert.ToInt32(ReadLine());

WriteLine("Введите третье число: ");

int c = Convert.ToInt32(ReadLine());

if (a > b && a > c)
{
    WriteLine($"Max = {a}");
}
else if (b > a && b > c)
{
    WriteLine($"Max = {b}");
}
else
{
    WriteLine($"Max = {c}");
}
