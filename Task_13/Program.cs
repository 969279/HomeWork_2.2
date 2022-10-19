/*
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. 
(Использовать только математические операции, нельзя использовать число как строку по типу number[2])
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
int num = ReadInt("Введите число: ");

if (num > 99)
{
   while( num > 999) 
   {
    num = num / 10;
   }
   num = num % 10;
   Console.Write($"Третья цифра - {num} ");
}
else
{
Console.Write("Третьей цифры нет");
}
