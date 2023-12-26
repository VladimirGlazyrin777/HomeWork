//Задача 1:  Напишите программу, которая принимает на вход число и 
//проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Enter Number: ");
int a = int.Parse(Console.ReadLine()!);

if (a % 7 == 0)
{
    Console.WriteLine("ДА кратно 7");
}
else
{
    Console.WriteLine("НЕТ не кратно 7");
}
if (a % 23 == 0)
{
    Console.WriteLine("ДА кратно 23");
}
else
{
    Console.WriteLine("НЕТ не кратно 23");
}

