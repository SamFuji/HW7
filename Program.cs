///////////////////////////////////////////
Console.Clear();
///////////////////////////////////////////

//ФУНКЦИИ для всех задач: 
// (Осторожно, не коммитить!) :)))



double[,] GetArrayDBL(int m, int n, int minValue, int maxValue) //функция заполнения рандомного двумерного массива с дробными числами для всех задач 
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue + 1), 2); //рандомные значения в десятичном формсате, с двумя знаками после запятой
        }
    }
    return result;
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

void PrintArrayDBL(double[,] inArray) //функция отображения дробного (DBL) массива

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

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

int [,] GetArray(int m, int n, int minValue, int maxValue) //функция заполнения рандомного двумерного массива с ЦЕЛЫМИ числами для всех задач 
{
    int [,] result = new int [m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1); 
        }
    }
    return result;
}

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

void PrintArray(int[,] inArray) //функция отображения массива
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

////////////////////////////////////////////////////////////////////////////////////////////////////////////////

//Задачи:

//Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.



// Console.Write("Введите количество строк: ");
// int mRows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int nColumns = int.Parse(Console.ReadLine());

// double[,] array = GetArrayDBL(mRows, nColumns, -100, 100);

// PrintArrayDBL(array);



////////////////////////////////////////////////////////////////////////////////////////////////////////////////

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.



// Console.Write("Введите количество строк: ");
// int Rows = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов: ");
// int Columns = int.Parse(Console.ReadLine());

// double[,] array = GetArrayDBL(Rows, Columns, -100, 100);

// PrintArrayDBL(array);

// Console.Write("Введите номер строки: ");
// int RowsNumber = int.Parse(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
//  int ColumnNumber = int.Parse(Console.ReadLine());
// if (0 <= RowsNumber && RowsNumber < Rows && 0 <= ColumnNumber && ColumnNumber < Columns)
//     {
//         Console.Write(array[RowsNumber, ColumnNumber]);
//     }
// else
// {
//     Console.Write("Position doesn't exist!");
// }

////////////////////////////////////////////////////////////////////////////////////////////////////////////////





// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.



Console.Write("Введите количество строк: ");
int Rows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int Columns = int.Parse(Console.ReadLine());

int[,] array = GetArray(Rows, Columns, 0, 10);

PrintArray(array);
Console.WriteLine( );


double summ = 0;
double average = 0;
double count =0;
for (int i = 0; i < array.GetLength(0);)
    {
        
        for (int j = 0; j < array.GetLength(1);  j++)
        {
        summ += array[i,j];
        count = (j+1);
        }
        average = Math.Round(summ/(count), 3);   
        Console.WriteLine($"Average of row's number ({i+1}) is: {average}");
        Console.WriteLine( );
        i++;
    }


