// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

using static System.Console;

WriteLine("Введите размер трехмерного массива через пробел");


int[] intParameters = Array.ConvertAll(ReadLine().Split(new string[] { " ", ", ", ";" }, StringSplitOptions.RemoveEmptyEntries), Convert.ToInt32);

int[,,] cube = GetCube(intParameters[0], intParameters[1], intParameters[2]);

PrintCube(cube);



int[,,] GetCube(int x, int y, int z)
{
    int[,,] newCube = new int[x, y, z]; // создаем трехмерный массив

    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int g = 0; g < z; g++)
            {
                newCube[i, j, g] = new Random().Next(10, 45);
            }
        }
    }


    int[] newArray = new int[newCube.GetLength(0) * newCube.GetLength(1) * newCube.GetLength(2)]; // преобразуем трехмерный массив в одномерный


        int k = 0; 
        for (int i = 0; i < newCube.GetLength(0); i++)
        {
            for (int j = 0; j < newCube.GetLength(1); j++)
            {
                for (int g = 0; g < newCube.GetLength(2); g++)
                {
                    newArray[k] = newCube[i, j, g];
                    k++;

                }
            }
        }

    

    
    int maxValue = newArray[0];
    for (int m = 0; m < newArray.Length; m++)
    {
        if(newArray[m] > maxValue) maxValue = newArray[m];
    }
    for (int m = 0; m < newArray.Length; m++)
    {
        for (int l = m + 1; l < newArray.Length; l++)
        {
            if(newArray[m] == newArray[l]) 
            {
                maxValue++;
                newArray[l] = maxValue;
            }
        }
    }


    int n = 0;
    for (int i = 0; i < newCube.GetLength(0); i++)
    {
        for (int j = 0; j < newCube.GetLength(1); j++)
        {
            for (int g = 0; g < newCube.GetLength(2); g++)
            {
                {
                    newCube[i, j, g] = newArray[n];
                    n++;
                }
            }      
            
        }
    }

    return newCube;
}


void PrintCube(int[,,] inArray)
{

    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int g = 0; g < inArray.GetLength(2); g++)
            {
                Write($"{inArray[i, j, g]} ({i}, {j}, {g}) ");
            }
            WriteLine();
        }
    }
}



