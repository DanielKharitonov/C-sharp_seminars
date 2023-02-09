﻿// Задача 46: Задайте двумерный массив размером mxn, заполненный случайными числами.

Console.Clear();

int[,] FillMatrix (int rows, int cols)
{
    Random rand = new Random();
    int[,] matrix = new int [rows,cols];

for (int i=0; i<rows;i++)
{
    for (int j=0;j<cols;j++)
    {
        matrix[i,j]=rand.Next(0,100);
    }
}
return matrix;
}

void PrintMatrix(int[,] matrix)
{
for (int i=0; i<matrix.GetLength(0);i++)
{
    for (int j=0;j<matrix.GetLength(1);j++)
    {
        System.Console.Write(matrix[i,j]+"\t");
    }
    System.Console.WriteLine();
}
}

System.Console.WriteLine("Введите m и n: ");
int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m,n);
System.Console.WriteLine();

PrintMatrix(matrix);