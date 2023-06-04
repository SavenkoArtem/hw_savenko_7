// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int Promt(string msg)
{
    System.Console.WriteLine(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 9);
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            System.Console.Write($"{array[i, j],3}    ");
        System.Console.WriteLine();
    }
}

double[] FindAVGColumns(int[,] array)
{
    double[] avg = new double[array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            avg[j] += array[i, j];
        }
    }

    for (int i = 0; i < avg.Length; i++)
    {
        avg[i] /= array.GetLength(0);
    }    


    return avg;
}

void PrintAVG(double[] array, int m)
{   
    Console.Write("Arithmetic mean of each column: "); 
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{Math.Round(array[i], 1)}");
        if (i != array.Length - 1)
        {
            Console.Write(";");
        }
    }
    Console.Write(".");
}


Console.Clear();

int m = Promt("Enter lenght's rows 'm'=");
int n = Promt("Enter lenght's collumns 'n'=");
int[,] res = new int[m,n];
FillArray(res);
PrintArray(res);
double[] x = FindAVGColumns(res);
PrintAVG(x, m);
Console.WriteLine();