/*
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4.

0,5 7 -2 -0,2

1 -3,3 8 -9,9

8 7,8 -7,1 9
*/





//Метод приёма числа на ввод
int GetNumberFromConsole (string message)
{
    Console.WriteLine(message);
    int result;
    while(true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Очень смешно! Введи число");
        }
    }
    return result;
}

//Метод инициализации и заполнения массива
double[,] InitDoubleMatrix (int m, int n)
{
    double[,]matrix = new double[m,n];
    Random rnd = new Random();

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i,j] = Math.Round(rnd.NextDouble()*(18) - 9, 1);//Random.NextDouble() * (maxValue - minValue) + minValue  
        }
    }
    return matrix;
}

//Метод печати массива
void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i,j]} ");
        }

        Console.WriteLine();
    }
}

int m = GetNumberFromConsole("Введите количество строк");
int n = GetNumberFromConsole("Введите количество столбцов");
double[,] matrix = InitDoubleMatrix(m,n);
PrintArray(matrix);