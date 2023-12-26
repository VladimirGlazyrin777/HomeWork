//Задача 4: Напишите программу, которая на вход принимает натуральное число N, 
//а на выходе показывает его цифры через запятую.

string no = "8965"; 
string [] numberArray = new string[no.Length]; 
int counter = 0; 

    for (int i = 0; i < no.Length; i++) 
    { 
    numberArray[i] = no.Substring(counter, 1); 
    counter++; 
    } 

Console.WriteLine(string.Join(" , ", numberArray)); 
