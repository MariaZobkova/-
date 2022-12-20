using static System.Console;
int number = new Random().Next(100, 1000);
WriteLine(number);

int a1 = number/100;
int a2 = number/10;
int a3 = number%10;
int a4 = a2%10;


Write(a4);

