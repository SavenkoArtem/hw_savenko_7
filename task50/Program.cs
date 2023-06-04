// Задача 50. Напишите программу, которая на вход принимает значение элемента в двумерном массиве, и возвращает позицию
// этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

void FindIndex(int[,] array, int x)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == x)
            {
                Console.WriteLine($"Element's index row: {i} column:{j}");
                return;
            }
        }
    }
    Console.WriteLine("There is no such number in the array!");
}


Console.Clear();

int m = Promt("Enter lenght's rows 'm'=");
int n = Promt("Enter lenght's collumns 'n'=");
int x = Promt("Enter a number to search for: ");
int[,] res = new int[m,n];
FillArray(res);
PrintArray(res);
FindIndex(res, x);