//   1. Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// int[] MyArray = CreateRandomArray(6, 100, 1000);

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }

// }

// ShowArray(MyArray);

// int sum = 0;

// void ArrayCheck(int[] array)
// {
//     for (int i = 0; i < MyArray.Length; i++)
//     {
//         if (MyArray[i] % 2 == 0) sum++;
         
//     }
// }

// ArrayCheck(MyArray);
// Console.WriteLine("-> " + sum);


//  2. Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// int[] MyArray = CreateRandomArray(6, -20, 20);

// void ShowArray(int[] array)
// {

//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }

// }

// ShowArray(MyArray); 

// int sum = 0;

// void ArrayCheck(int[] array)
// {
//     for (int i = 1; i < MyArray.Length; i = i + 2)
//     {
//         sum = sum + MyArray[i];
//     }
// }

// ArrayCheck(MyArray);
// Console.WriteLine("-> " + sum);


//  3. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// int[] MyArray = CreateRandomArray(6, 1, 50);

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// ShowArray(MyArray); 

// int min = 50;
// int max = 1; 

// void ArrayCheck(int[] array)
// {
//     for (int i = 0; i < MyArray.Length; i++)
//     {
//        if(MyArray[i] > max) max = MyArray[i];

//        if(MyArray[i] < min) min = MyArray[i];
//     }
// }

// ArrayCheck(MyArray);
// Console.WriteLine(" -> " + (max - min));


//  Дополнительно:

//  1. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// int[] MyArray = CreateRandomArray(123, 1, 150);

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// ShowArray(MyArray); 

// int sum = 0; 

// void ArrayCheck(int[] array)
// {
//     for (int i = 0; i < MyArray.Length; i++)
//     {
//        if(MyArray[i] > 9 && MyArray[i] < 100) sum = sum + 1;

//     }
// }

// ArrayCheck(MyArray);
// Console.WriteLine(" -> " + sum);


//  2.Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// int[] MyArray = CreateRandomArray(7, -1, 10);

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// ShowArray(MyArray); 
 
// Console.Write(" ->  ");

// int size = MyArray.Length;
// int result = 0;
// int j = MyArray.Length - 1;
// int i = 0;
// int n = size / 2;

// while(i < n && n < j){
//     result = MyArray[i] * MyArray[j];
//     Console.Write(result + " ");
//     i++;
//     j--;
// }
    
// if(size % 2 == 0) Console.Write(MyArray[n - 1] * MyArray[j]);
    
// else{
//     Console.Write(MyArray[n]); 
// }
