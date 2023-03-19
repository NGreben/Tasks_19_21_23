﻿/*
Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/

int x1, x2, y1, y2, z1, z2;

Console.Write($"Введите координату x1 первой точки: ");
int.TryParse(Console.ReadLine()!, out x1);
Console.Write($"Введите координату y1 первой точки: ");
int.TryParse(Console.ReadLine()!, out y1);
Console.Write($"Введите координату z1 первой точки: ");
int.TryParse(Console.ReadLine()!, out z1);

Console.Write($"Введите координату x2 второй точки: ");
int.TryParse(Console.ReadLine()!, out x2);
Console.Write($"Введите координату y2 второй  точки: ");
int.TryParse(Console.ReadLine()!, out y2);
Console.Write($"Введите координату z2 второй  точки: ");
int.TryParse(Console.ReadLine()!, out z2);

Console.Write($"{Math.Round(Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1)), 2)}");