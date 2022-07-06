//  Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// double[,] RandomArray(int m, int n, int min, int max)
// {
//     double[,] result = new double[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().NextDouble()*10;
//         }

//     }
//     return result;

// }



// void PrintArray(double[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]:f1} ");
//         }
//     Console.WriteLine();
//     }

// }

// Console.Write("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите минимальное значение: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите максимальное значение: ");
// int max = Convert.ToInt32(Console.ReadLine());


// double[,] array = RandomArray(rows, columns, min, max);

// PrintArray(array);


//  Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// int[,] CreateRandomArray(int m, int n, int min, int max)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().Next(min, max + 1);
//         }

//     }
//     return array;
// }

// int[,] myArray = CreateRandomArray(5, 7, 1, 10);

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// ShowArray(myArray);

// Console.Write("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// void Numarray(int[,] array)
// {

//  for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if (rows == i + 1 && columns == j + 1)
//                 Console.Write(rows + "," + columns + " ==> " + array[i, j] + " ");
//         }

//     }
//     if (rows > array.GetLength(0) || columns > array.GetLength(1))
//         Console.Write(rows + "," + columns + " ==> " + "такого числа в массиве нет");

// }

// Numarray(myArray);


//  Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] array = GetArray( rows, columns, min, max);

// PrintArray(array);

// double[] averageColumns = GetResultArray(array);

// Console.WriteLine($"Среднее арифметическое каждого столбца = {String.Join("; ",averageColumns)}");

// int[,] GetArray(int m, int n, int min, int max)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(min, max + 1);
//         }
//     }
//     return result;
// }

// void PrintArray(int[,] array)
// {
//    for (int i = 0; i < array.GetLength(0); i++)
//    {
//        for (int j = 0; j < array.GetLength(1); j++)
//        {
//             Console.Write(array[i, j] + "    ");
//        }
//         Console.WriteLine();
//    }
// }



// double[] GetResultArray(int[,] inArray)

// {
//     double[] result = new double[array.GetLength(1)];


//     for (int column = 0; column < array.GetLength(1); column++)
//     {

//      double sum = 0;

//         for (int rows = 0; rows < array.GetLength(0); rows++)
//         {

//          sum += array[rows, column];   
        
//         }
//         result[column] = Math.Round(sum/array.GetLength(0),2);
//     }

//     return result; 

// }
    

