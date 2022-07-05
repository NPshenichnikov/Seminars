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

int[,] CreateRandomArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }

    }
    return array;
} 

int[,] myArray = CreateRandomArray(5, 7, 1, 10);

void ShowArray(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
    Console.WriteLine();
    }
    Console.WriteLine();
}

ShowArray(myArray);

Console.Write("Введите число строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

void Numarray(int[,] array){
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(i + 1 == rows && j + 1 == columns)
            Console.Write(rows + "," + columns +" ==> " + array[i, j] + " ");
            if(rows > i + 1 || columns > j +) 
            Console.Write(rows + "," + columns +" ==> " + " такого числа в массиве нет");
        }

        
               
    }
    
   }
     
Numarray(myArray);


//  Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
//         Console.WriteLine();
//     }
// }

// void ArithMean(int[,] array)

// {
//     int sum = 0;
    
    
//     for (int j = 0; j < array.GetLength(1); j++)
//     {
//       for (int i = 0; i < array.GetLength(0); i++)
//       {
        
//          sum += array[0, j];   
            
//       }
        
     
//       Console.Write(sum + " ");  
      
//     }
    
// }

// Console.Write("Enter number of rows: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number of columns: ");
// int columns = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter min number: ");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter max number: ");
// int max = Convert.ToInt32(Console.ReadLine());

// int[,] myArray = CreateRandomArray( rows, columns, min, max);

// ShowArray(myArray);

// ArithMean(myArray);
