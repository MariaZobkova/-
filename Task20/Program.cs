using static System.Console;

WriteLine("Введите координату точки 1 по оси x: ");
int x1 = int.Parse(ReadLine()!);
WriteLine("Введите координату точки 1 по оси y: ");
int y1 = int.Parse(ReadLine()!);
WriteLine("Введите координату точки 1 по оси z: ");
int z1 = int.Parse(ReadLine()!);
WriteLine("Введите координату точки 2 по оси x: ");
int x2 = int.Parse(ReadLine()!);
WriteLine("Введите координату точки 2 по оси y: ");
int y2 = int.Parse(ReadLine()!);
WriteLine("Введите координату точки 2 по оси z: ");
int z2 = int.Parse(ReadLine()!);
double lenght = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2) + Math.Pow(z2-z1, 2));

WriteLine($"Длинна отрезка между точками равна {lenght:f2}");
