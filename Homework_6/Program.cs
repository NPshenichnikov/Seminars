//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


// Console.Write("Введите элементы(через пробел): ");
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов > 0: {count}");


//  Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

// Console.Write("Введите целое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int count = 0;

// while (num >= 1)
// {
//     count++;
//     num = num / 2;
// }

// int[] CreateRandomArray(int count);
// {
//     int[] array = new int[count];
//     for (int i = 0; i < count; i++)
//     {
//         while (num >= 1)
//         {
//             if (num % 2 != 0)
//             {
//                 array[i] = 1;
//             }

//             else
//             {
//                 array[i] = 0;
//             }
//             num = num / 2;

//         }
//     }
//     return array;
// }
// CreateRandomArray(count);


// //  Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.Write("Введите k1: ");
// double k1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b1: ");
// double b1 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите k2: ");
// double k2 = Convert.ToDouble(Console.ReadLine());
// Console.Write("Введите b2: ");
// double b2 = Convert.ToDouble(Console.ReadLine());

// // Так как,по условию значения (Y) функций совпадают,то:
// // k1 * x + b1 = k2 * x + b2
// // k1 * x - k2 * x = b2 - b1
// // x * (k1 - k2) = b2 - b1
// // x = (b2 - b1) / (k1 - k2)

// double x = (b2 - b1) / (k1 - k2);
// double y = k1 * x + b1;

// x = Math.Round(x, 2);
// y = Math.Round(y, 2);

// Console.WriteLine($"Пересечение в точке: ({x};{y})");



//  Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

Console.Write("Введите число N: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 2)
Console.Write(0 + " " + 1 + " ");

int count = 2;
int sum = 1;
int sum1 = 0;
int sum2 = 0;
int sum3 = 0;
int sum4 = 0;
int sum5 = 0;
int sum6 = 0;

while(num >= count){
    Console.Write(sum + " "); 
    count++;
    sum2 = sum + sum + 1;
    Console.Write(sum + " ");
    count++;
    sum3 = sum1 + sum2  ;
    Console.Write(sum + " ");
    count++;
    sum4 = sum2 + sum3;
    Console.Write(sum + " ");
    count++;
    sum5 = sum3 + sum4;
    Console.Write(sum + " ");
    count++;
    sum6 = sum4 + sum5;

}



