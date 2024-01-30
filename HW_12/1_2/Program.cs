//Задача 2: Задайте строку, содержащую латинские буквы в обоих регистрах. 
//Сформируйте строку, в которой все заглавные буквы заменены на строчные.


using System;
 
public class Example
{
    public static void Main()
    {
        string s = "Hello WoRld";
 
        s = s.ToLower();
 
        Console.WriteLine(s);        // привет мир
    }
}


