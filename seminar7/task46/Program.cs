﻿// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.
// m = 3, n = 4
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1

int ReadNumber (string messageToUser)
{
     Console.WriteLine(messageToUser);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

int [,] GetRandomMatrix(int rows, int colums, int leftboarder = 0, int rightboarder = 10)
{
    int [,] matrix = new int [rows, colums];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Random.Shared.Next(leftboarder, rightboarder +1 );
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int m = ReadNumber("Ввееедите количество строк");
int n = ReadNumber("Введите количество столбцов");

int[,] myMatrix = GetRandomMatrix(m, n);
PrintMatrix(myMatrix);

