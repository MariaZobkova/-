// Tom Marvolo Riddle => I am Lord Voldemort
// Можно ли с одной строки собрать вторую?


using static System.Console;
using static System.Array;
Clear();

Write("Введите строку ");
string str1 = ReadLine()!;

Write("Введите вторую строку ");
string str2 = ReadLine()!;


ChecMagic(str1, str2);

void ChecMagic (string One, string Two)
{
    One = One.ToLower();
    Two = Two.ToLower();

    char[] charOne = One.ToCharArray();
    char[] charTwo = Two.ToCharArray();

    Array.Sort(charOne);
    Array.Sort(charTwo);

    bool result = Enumerable.SequenceEqual(charOne, charTwo);
    
    WriteLine(result);
}
