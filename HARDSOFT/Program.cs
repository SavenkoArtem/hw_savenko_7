// Задача HARD SORT необязательная. Считается за три обязательных
// Задайте двумерный массив из целых чисел. Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
// Например, задан массив:
// 1 4 7 2
// 5 9 10 3
// После сортировки
// 1 2 3 4
// 5 7 9 10

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

int[] CreateOneArray(int[,] array)
{
    int[] newOne = new int[array.GetLength(0)*array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            {                
                newOne[k] = array[i, j];
                k++;
            }

    return newOne;
}

void SortArray(int[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            if(array[i] > array[i + 1])
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }        
        }        
    }    
}

void SorteredArray(int[] arrayOne, int[,] arrayTwo)
{    
    int k = 0;
    for (int i = 0; i < arrayTwo.GetLength(0); i++)
    {
        for (int j = 0; j < arrayTwo.GetLength(1); j++)
        {
            arrayTwo[i, j] = arrayOne[k];
            k++;
        }        
    }
    
}

Console.Clear();

int m = Promt("Enter lenght's rows 'm'=");
int n = Promt("Enter lenght's collumns 'n'=");
int[,] res = new int[m,n];
FillArray(res);
PrintArray(res);
int[] newOne = CreateOneArray(res);
SortArray(newOne);
SorteredArray(newOne, res);
System.Console.WriteLine();
PrintArray(res);