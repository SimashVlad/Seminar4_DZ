﻿// // Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16




Console.WriteLine("Введите первое число");
double num = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
double num2 = double.Parse(Console.ReadLine());

double result = Math.Pow(num, num2);
Console.WriteLine(result);


