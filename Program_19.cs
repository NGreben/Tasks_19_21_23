/*
Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int number;
Console.Write($"Введите пятизначное число: ");
int.TryParse(Console.ReadLine()!, out number);
if (number < 10000 | number > 99999)
    Console.Write($"Число не пятизначное");
else if (number / 10000 != number % 10)
    Console.Write($"Не полиндром");
else if (number / 1000 % 10 == number / 10 % 10)
    Console.Write($"Полиндром");