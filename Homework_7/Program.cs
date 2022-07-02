//  Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// int[,] CreateRandomArray(int m, int n)
// {
//     int[,] array = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             array[i, j] = new Random().NextDouble();
//         }

//     }
//     return array;

// }



// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//     Console.WriteLine();
//     }

// }

// Console.Write("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandomArray(rows, columns);

// ShowArray(myArray);


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

// void ShowArray(int[,] array)
// {

//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + " ");
//         }
//     Console.WriteLine();
//     }
//     Console.WriteLine();
// }

// Console.Write("Введите число строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите число столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// void Numarray(int[,] array){
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             if(i == rows && j == columns)
//             Console.Write(i + "," + j +" ==> " + array[i, j] + " ");
            
//         }
//     }
//     if(rows > 5 || columns > 5) 
//     Console.Write(rows + "," + columns +" ==> " + " такого числа в массиве нет");
   
// }

// int[,] myArray = CreateRandomArray(5, 5, 1, 10);

// ShowArray(myArray);
// Numarray(myArray);


//  Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.






