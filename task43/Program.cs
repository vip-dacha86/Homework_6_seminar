﻿// Напишите программу которая найдет точку пересечения двух прямых заданных уравнением 
// y=k1*x+b1,y=k2*x+b2  значения b1,k1,b2,k2 задаются пользователем
// b1=2,k1=5,b2=9,k2=9->(-0,5;-0,5)
Console.Clear();

Console.Write("Введите b1: ");
double b1 = int.Parse(Console.ReadLine());
Console.Write("Введите k1: ");
double k1 = int.Parse(Console.ReadLine());
Console.Write("Введите b2: ");
double b2 = int.Parse(Console.ReadLine());
Console.Write("Введите k2: ");
double k2 = int.Parse(Console.ReadLine());


 
double x = (b2 - b1) / (k1 - k2);
double y = k1 * (b2 - b1) / (k1 - k2) + b1;
 

Console.WriteLine($"Точка пересечения двух прямых X = {x:0.000} , Y = {y:0.000}\n");