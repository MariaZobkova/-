using static System.Console;

Write("Введите число:");
bool isParse = int.TryParse(ReadLine(), out int i);
if (!isParse)
{
    WriteLine("Введено не число");
    return;
}
if (i < 1)
{
    WriteLine("Число должно быть натуральным");
}
int n = 1;

while (n <= i)
{
    Write(Math.Pow(n, 3) + "  ");
    n++;
}
