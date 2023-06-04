// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int Promt(string msg)
{
    Console.Write(msg);
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    return num;
}

void FillArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Math.Round((new Random().NextDouble() * 15 - 10), 1);
        }        
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j], 3}   ");
        }
        Console.WriteLine();
    }
}

int m = Promt("Enter m: ");
int n = Promt("Enter n: ");

double[,] res = new double[m,n];
FillArray(res);
PrintArray(res);