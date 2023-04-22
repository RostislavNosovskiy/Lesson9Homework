/*** Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */
Console.Clear();
Console.WriteLine("Введите меньшее число (M) из промежутка :");
int M = int.Parse(Console.ReadLine());
Console.WriteLine("Введите большее число (N) из промежутка:");
int N = int.Parse(Console.ReadLine());

int Metod (int N, int M){
if (N == M){
    return N;
}
return N + Metod(--N, M);}
Console.WriteLine($" -> {Metod(N, M)}");