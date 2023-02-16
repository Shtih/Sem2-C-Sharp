//Задача 15: Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет

Console.WriteLine("Введите цифру от 1 до 7: ");
int weekday = Convert.ToInt32(Console.ReadLine());
if(weekday >= 1 && weekday <= 5)
{
    Console.WriteLine("Иди батрач");
}
if(weekday == 6 || weekday == 7)
{
    Console.WriteLine("Пошли пить винишко в рестик, у тебя выходной");
}
if(weekday > 7)
{
    Console.WriteLine("Вы ввели не допустимое значение");
}