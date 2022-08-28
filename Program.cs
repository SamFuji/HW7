
Console.Clear();

double[,] GetArray(int m, int n, int minValue, int maxValue) //функция вызова рандомного двумерного массива для всех задач
{
    double [,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {   
            result[i, j] = Math.Round(new Random().NextDouble() + new Random().Next(minValue, maxValue + 1), 2);
          }
    }
    return result;

}
void PrintArray(double[,] inArray)
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

Console.Write("Введите количество строк: ");
int mRows = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов: ");
int nColumns = int.Parse(Console.ReadLine());

double[,] array = GetArray(mRows, nColumns, -100, 101);

PrintArray(array);

// double[,] arrayMatrix = new double[mRows, nColumns]; 

// for (int i = 0; i < arrayMatrix.GetLength(0); i++) 
// { 
//     for (int j = 0; j < arrayMatrix.GetLength(1); j++)
//     {
//          arrayMatrix[i, j] = new Random().NextDouble(-100, 101);
//          Console.Write($"{arrayMatrix[i,j]} ");
//     } 

//     Console.WriteLine();
// }
