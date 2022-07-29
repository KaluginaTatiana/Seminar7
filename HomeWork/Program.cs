void FillArrayDouble(double[,] array)
{
    Random rand = new Random();
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = Math.Round(rand.NextDouble(), 1) + rand.Next(-100, 100);
        }
    }
}

void PrintArrayDouble(double[,] array)
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

void FillArrayInt(int[,] array)
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

void PrintArrayInt(int[,] array)
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

void ArithmeticMeanInColumn(int[,] array)
{
    int rows = array.GetLength(0);
    int columns = array.GetLength(1);
    Console.Write("Среднее арифметическое значение элементов каждого столбца: ");
    for (int j = 0; j < columns; j++)
    {
        double summ = 0;
        for (int i = 0; i < rows; i++)
        {
            summ = summ + array[i, j];
        }
        Console.Write(" " + Math.Round(summ / rows, 1, MidpointRounding.AwayFromZero) + ";");
    }
    Console.Write("\b");
    Console.WriteLine(".");
}

void Task47() // Задайте двумерный массив размером m×n, заполненный случайными вещественными числами, 
              // округлёнными до одного знака.
{
    int m = 4;
    int n = 5;
    double[,] matrix = new double[m, n];
    FillArrayDouble(matrix);
    PrintArrayDouble(matrix);
}

void Task50() // Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
              // и возвращает значение этого элемента или же указание, что такого элемента нет.
{
    int m = 4;
    int n = 5;
    int[,] matrix = new int[m, n];
    FillArrayInt(matrix);
    PrintArrayInt(matrix);
    Console.WriteLine();
    Console.WriteLine("Введите номер строки таблицы для вывода необходимого элемента");
    int row = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца таблицы для вывода необходимого элемента");
    int column = Convert.ToInt32(Console.ReadLine());
        if (row <= m && column <= n)
    {
        Console.WriteLine($"Элемент, находящийся в {row} строке и в {column} столбце таблицы, равен {matrix[row - 1, column - 1]}.");
    }
    else
    {
        Console.WriteLine("Такого элемента нет.");
    }
}

void Task52() // Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
{
    int m = 4;
    int n = 5;
    int[,] matrix = new int[m, n];
    FillArrayInt(matrix);
    PrintArrayInt(matrix);
    Console.WriteLine();
    ArithmeticMeanInColumn(matrix);
}

Task47();
Task50();
Task52();
