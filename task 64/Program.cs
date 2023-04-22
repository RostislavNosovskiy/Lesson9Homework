/*** Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */
Console.Clear();
Console.WriteLine("Введите наибольшее число из промежутка:");
int maxnum = int.Parse(Console.ReadLine());
int minnum = 1;

string Metod (int maxnum, int minnum){
if (minnum == maxnum){
    return maxnum.ToString();
}
return maxnum +"," +Metod(--maxnum, minnum);}
Console.WriteLine($" -> {Metod(maxnum, minnum)}");