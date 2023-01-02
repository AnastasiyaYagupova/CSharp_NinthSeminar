/*
Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
Выполнить с помощью рекурсии.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите первое число");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число");
int N = Convert.ToInt32(Console.ReadLine());

int SumOfNumbers001(int M, int N)
{
    if (M > N) return 0;
    else return M + SumOfNumbers001(M + 1, N);
}

int SumOfNumbers002(int M, int N)
{
    if (N > M) return 0;
    else return N + SumOfNumbers002(M, N + 1);
}

if(M < N)
{
Console.WriteLine(SumOfNumbers001(M,N));
}
else
{
    Console.WriteLine(SumOfNumbers002(M,N));
}