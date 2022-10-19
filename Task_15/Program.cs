/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет
*/
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int num = ReadInt("Введите номер дня недели: ");

if (num > 7)
{
    Console.Write("Нет такого дня недели");
}
else if (num == 6 || num == 7)
{
    Console.Write("Выходной день");
}
else
{
Console.Write("Рабочий день");
}