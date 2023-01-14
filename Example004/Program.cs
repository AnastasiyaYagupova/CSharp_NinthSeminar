/*
Задача 4*. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

Console.WriteLine("Введите количество срок ");
int i = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество стобцов ");
int j = Convert.ToInt32(Console.ReadLine());

void FillArray(int [,] collection, int i, int j, int m, int n, int count) 
{
    if(count <= j / 2)
    {
        while(n < collection.GetLength(1)-count)
        {
            collection[m,n] = 1;
            n++;
        }
        while(m < collection.GetLength(0)-count)
        {
            collection[m,n] = 2;
            m++;
        }
        while(n > count-1)
        {
            collection[m,n] = 3;
            n--; 
        }
        while(m > count-1)
        {
            collection[m,n] = 4;
            m--;
        }
        FillArray(collection,i,j,m+1,n+1,count+1);
    }
        else if(count-0.5 == (double)j / 2)
    {
        collection[m,n] = 5;
    }
} 

void PrintArray(int [,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write(collection[i,j] + "|");
        }
        Console.WriteLine();
    }
}

int[,] Array = new int [i,j];
int m = 0;
int n = 0;
int count = 1;
FillArray(Array,i,j,m,n,count);
PrintArray(Array);