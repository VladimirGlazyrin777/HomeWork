//Задача 3: Напишите программу, которая перевернёт одномерный массив 
//(первый элемент станет последним, второй – предпоследним и т.д.).


class Program
{
        static void Main(string[] args)
        {
                int[] myArray = { 1, 10, 0, -5 };
                Console.Write("Вывод массива: ");
                for (int i = myArray.Length - 1; i >= 0; i--)
                {
                        Console.Write(myArray[i] +" ");     
                }
                Console.ReadLine();
        }
}