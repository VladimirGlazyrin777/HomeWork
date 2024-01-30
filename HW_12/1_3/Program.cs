//Задача 3: Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.WriteLine("Введите строку : ");
          
        String sl = Console.ReadLine();
            char[] sym = sl.ToCharArray();
           { if (IsPalindrom(sym))
                Console.WriteLine("Палиндром");
            else
                Console.WriteLine("Не палиндром");
        }
        static bool IsPalindrom(char[] word)
        {
            for (int i = 0; i < word.Length / 2; i++)
                if (word[i] != word[word.Length - 1 - i])
            return false;
            return true;
        }
    
