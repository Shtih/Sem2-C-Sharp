﻿//Задача №11. Работа в группах
// Напишите программу, которая выводит случайное трехзначное число и 
//удаляет вторую цифру этого числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int number = new Random().Next(100, 1000);
Console.WriteLine(number);
int digit1 = number / 100;
int digit2 = number%10;
int resalt = digit1 * 10 + digit2;
Console.WriteLine(resalt);


