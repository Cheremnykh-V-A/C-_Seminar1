﻿//Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y).

Console.WriteLine("Введите координатную четверть");
int cord = Convert.ToInt32(Console.ReadLine());

if (cord == 1)
{
    Console.WriteLine("x > 0 && y > 0");
}
else if (cord == 2)
{
    Console.WriteLine("x < 0 && y > 0");
}
else if (cord == 3)
{
    Console.WriteLine("x < 0 && y < 0");
}
else if (cord == 4)
{
    Console.WriteLine("x > 0 && y < 0");
}
else
{
    Console.WriteLine("Нет такой координатной четверти");
}