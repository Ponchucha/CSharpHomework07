/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

17 -> такого числа в массиве нет
*/

// в примере вводятся не позиции элемента, а его значение.
// Я буду придерживаться текста задания и принимать на вход позиции, а выдавать его значение.

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
            Console.WriteLine("Это ни в какие ворота. Нужно натуральное число");
        }
    }
    return result;
}

//Метод инициализации и заполнения матрицы
int[,] InitRandomMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            matrix[i, j] = rnd.Next(0, 99);
        }
    }
    return matrix;
}

// Метод поиска элемента по его позициям
void PrintElement(int[,] matrix, int x, int y)
{
    if (matrix.GetLength(0) < y || matrix.GetLength(1) < x)
    {
        Console.WriteLine("Числа с такой позицией в массиве нет");
    }
    else
    {
        Console.WriteLine($"Это число {matrix[y-1, x-1]}");
    }
}

//Метод печати массива
void PrintArray(int[,] matrix)
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
int[,] matrix = InitRandomMatrix(m,n);
PrintArray(matrix);
int x = GetNumberFromConsole("Введите номер столбца");
int y = GetNumberFromConsole("Введите номер строки");
PrintElement(matrix,x,y);
