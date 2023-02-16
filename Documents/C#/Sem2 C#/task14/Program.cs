//Задача №14. Работа в группах
//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 
//7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

Console.WriteLine("Ведите число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
if(number1%7 == 0 && number1%7 ==0)
{
    Console.WriteLine("Число кратно 7 и 23");
}
else
{
    Console.WriteLine("Число не кратно 7 и 23");
}