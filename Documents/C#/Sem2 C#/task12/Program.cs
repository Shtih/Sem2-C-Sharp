﻿//Задача №12. Работа в группах
//Напишите программу, которая будет принимать на вход два числа и выводить, 
//является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//
//16, 4 -> кратно

Console.WriteLine("Ведите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ведите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());
int mod = number1 % number2;
if(mod == 0)
{
    Console.WriteLine("Число кратно");
}
else
{
    Console.WriteLine($"Некратно {mod}");
}