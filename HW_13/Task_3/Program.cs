//Задача 3: Задайте произвольный массив. 
//Выведете его элементы, начиная с конца. 
//Использовать рекурсию, не использовать циклы.
class program
{
static void print(int[] array, int first = 0)
{
    if(first != array.Length) {
        print(array, first + 1);
        Console.Write($"{array[first]} ");
    }
}
        
 static void Main(string[] args)
{
    var array = new int[]{1, 2, 5, 0, 10, 34 };
    print(array);            
}

}