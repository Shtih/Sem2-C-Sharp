//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или 
//сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

int number  = new Random().Next(1, 1000000000);
Console.WriteLine(number);
if(number <= 99)
{
   goto Total;
}
while(99 < number && number > 1000)
{
    number = number / 10;
}
Console.WriteLine(number);
int digit3 = number%10;
Console.WriteLine(digit3);
Total:
Console.WriteLine("Третья цифра отсутствует");