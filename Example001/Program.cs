/*
Задача 1: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"
*/

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
int B = 1;
string OutputOfNumbersUpToN (int B, int N)
{
    if (B <= N) return OutputOfNumbersUpToN(B + 1, N) + $"{B} ";
    else return String.Empty;
}
Console.WriteLine(OutputOfNumbersUpToN(B,N));