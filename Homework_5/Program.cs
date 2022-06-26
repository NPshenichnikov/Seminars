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
//        if(MyArray[i] > 9 && MyArray[i] < 99) sum = sum + 1;

//     }
// }

// ArrayCheck(MyArray);
// Console.WriteLine(" -> " + sum);
