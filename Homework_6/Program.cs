//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


// Console.Write("Введите элементы(через пробел): "); 
// int[] arr = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

// int count = 0;

// for (int i = 0; i < arr.Length; i++)
// {
//     if (arr[i] > 0)
//     {
//         count++;
//     }
// }

// Console.WriteLine($"Кол-во элементов больше 0  => {count}");


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

// if(k1 * x + b1 == k2 * x + b2) Console.WriteLine($"Пересечение прямых в точке: ({x};{y})");

// else Console.WriteLine("Эти прямые паралельны или совпадают");


//  Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Console.Write("Введите целое число N: ");
// int num = Convert.ToInt32(Console.ReadLine());



// if(num < 1) Console.Write("Введите корректное число");


// if(num == 1)
// Console.Write("Число Фибоначчи: " + 0 + " ");
// if(num == 2)
// Console.Write("Число Фибоначчи: " + 0 + " " + 1 + " ");

// if(num >= 3){

// Console.Write("Число Фибоначчи: ");
// Console.Write(0 + " " + 1 + " " + 1 + " "); 

// }

// int sum = 1;
// int sum2 = 1;

// for (int i = 0; i < num - 3; i++) {
   
//    sum = sum + sum2;
//    sum2 = sum - sum2;
   
// Console.Write(sum + " ");
// }
