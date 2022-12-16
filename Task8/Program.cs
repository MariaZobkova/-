using static System.Console;

WriteLine("Введите число: ");

int a = Convert.ToInt32(ReadLine());
int b = 1;

if (a >= 1)
{
    while (a >= b)
    {
        if ((b % 2)==0)
        {
            Write($"{b}, ");
            b = b + 1;
        }
        else
        {
            b = b + 1;
        }
    }
}
else 
{
    Write("Вы ввели недопустимое значение.");
}
