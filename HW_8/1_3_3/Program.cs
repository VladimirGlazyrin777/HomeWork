//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] 
//и показывает наибольшую цифру числа.

///ВТОРОЕ РЕШЕНИЕ!

int number = new Random().Next(10, 100);
Console.WriteLine($"случайное число из отрезка [10, 99]={number}");

int FirstDigit = number / 10;
int SecondDigit = number % 10;

if (FirstDigit > SecondDigit)
{
    Console.WriteLine($"наибольшая цифра числа{FirstDigit}");
}
else
{
    Console.WriteLine($"наибольшая цифра числа{SecondDigit}");
}

