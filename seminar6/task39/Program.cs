﻿// Напишите программу, которая
// перевернёт одномерный массив (последний элемент
// будет на первом месте, а первый - на последнем и
// [1 2 3 4 5] -> [5 4 3 2 1]
// [6 7 3 6] -> [6 3 7 6]

int[] GetRandomArray (int lenght, int leftRange, int rightRange)
{
    int[] array = new int[lenght];

    for(int i = 0; i < lenght; i++)
    {
        array[i] = Random.Shared.Next(leftRange, rightRange +1);
    }
    return array;
}

void ReversArray(int[] array)
{
    for(int i = 0; i < array.Length / 2; i++)
    {
        int temp = array[i];
        array[i] = array[array.Length - i - 1];
        array[array.Length - i - 1] = temp;
    }
}

const int LENGHT = 12;
const int LEFTBOARDER = -10;
const int RIGHTBOARDER = 10;

int[] myArray = GetRandomArray(LENGHT, LEFTBOARDER, RIGHTBOARDER);
Console.WriteLine($"[{string.Join(", ", myArray)}]");

ReversArray(myArray);
Console.WriteLine($"[{string.Join(", ", myArray)}]");