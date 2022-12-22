/*
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

//Метод приёма числа на ввод
int GetNumberFromConsole(string message)
{
    Console.WriteLine(message);
    int result;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Где-то заплакал один автор кода. Введите натуральное число, бессердечные вы люди");
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
            matrix[i,j] = Math.Round(rnd.NextDouble()* 9 + 0, 0);//Random.NextDouble() * (maxValue - minValue) + minValue  
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

//Метод печати среднего арифметического из каждого столбца
void PrintColumnAverage(double[,]matrix)
{
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j,i];
        }
        Console.WriteLine($"Среднее значение элемента в {i+1} столбце составляет {Math.Round(sum / matrix.GetLength(0),2)}");
    }
}


int m = GetNumberFromConsole("Введите количество строк");
int n = GetNumberFromConsole("Введите количество столбцов");
double[,]matrix = InitDoubleMatrix(m,n);
PrintArray(matrix);
PrintColumnAverage(matrix);