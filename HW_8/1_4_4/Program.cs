//Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.

//ВТОРОЕ РЕШЕНИЕ

Console.WriteLine("Enter Number: ");
int number = int.Parse(Console.ReadLine()!);

            int result = 0;
            int y = number.ToString().Length;
 
            while (number > 0)
            {
                result *= 10;
                result += number % 10;
                number /= 10;
            }
 
            for (int i = 0; i < y; i++)
            if (i == y - 1)
            {
                Console.Write(result % 10);
            } 
            else
            {
                Console.Write(result % 10 + " , ");
                result /= 10;
            }
 
