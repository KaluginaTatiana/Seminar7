void Task46()
{
    // Задайте двумерный массив размером m*n, заполненный случайными целыми числами

    int m = 4;
    int n = 5;
    int[,] matrix = new int[m, n];
    FillArray(matrix);
    PrintArray(matrix);
}


void FillArray(int[,] array)
{
    Random rand = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = rand.Next(0, 10);
        }
    }
}

void FillArray46(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = i + j;
        }
    }
}
void ChangeElements49(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 1; i < rows; i++)
    {
        for (int j = 1; j < columns; j++)
        {
            if (i % 2 ==0 && j % 2 == 0) array[i, j] = array[i, j] * array[i, j];
        }
    }
}
void SummElementsDiagonal51(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    int summ = 0;
    Console.Write("Сумма элементов главной диагонали: ");
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (i == j)
            {
                summ = summ + array[i, j];
                Console.Write(array[i, j] + "+");
            }
        }
    }
    Console.Write("\b");
    Console.WriteLine($"={summ}.");
}
void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

//Task46();

void Task48()
{
    int m = 6;
    int n = 7;
    int[,] matrix = new int[m,n];
    FillArray46(matrix);
    PrintArray(matrix);
}

//Task48();

void Task49()
{
    int m = 3;
    int n = 4;
    int[,] matrix = new int[m,n]; 
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    ChangeElements49(matrix);
    PrintArray(matrix);
}

//Task49();

void Task51()
{
    int m = 4;
    int n = 4;
    int[,] matrix = new int[m,n];
    FillArray(matrix);
    PrintArray(matrix);
    Console.WriteLine();
    SummElementsDiagonal51(matrix);
}

Task51();
