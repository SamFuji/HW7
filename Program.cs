
Console.Clear();

double[,] GetArray(int m, int n, int minValue, int maxValue) //функция заполнения рандомного двумерного массива для всех задач
{
    double [,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {   
            result[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue + 1), 2); //рандомные значения в десятичном формсате, с двумя знаками после запятой
          }
    }
    return result;

}
void PrintArray(double[,] inArray) //функция отображения массива
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]}     ");
        }
        Console.WriteLine();
    }
}



//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// Console.Write("Введите количество строк: ");
// int mRows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int nColumns = int.Parse(Console.ReadLine());

// double[,] array = GetArray(mRows, nColumns, -100, 100);

// PrintArray(array);


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.


Console.Write("Введите количество строк: ");
int Rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int Columns = int.Parse(Console.ReadLine());

double[,] array = GetArray(Rows, Columns, -100, 100);

PrintArray(array);

Console.Write("Введите номер строки: ");
int RowsNumber = int.Parse(Console.ReadLine());
if (0 <= RowsNumber && RowsNumber < Rows )
{
    Console.Write("Введите номер столбца: ");
    int ColumnNumber = int.Parse(Console.ReadLine());
    if (0 <= ColumnNumber && ColumnNumber < Columns );
    {
        Console.Write(array[RowsNumber,ColumnNumber]);
    }
}
else
{
    Console.Write("Position doesn't exist!");
}    

// Console.Write("Введите номер столбца: ");
// int nColumns = int.Parse(Console.ReadLine());



// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.