//  Задача 63,65: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// string PrintNumbers(int start, int end){
//     if(start == end) return start.ToString();
//     return (start + " " + PrintNumbers(start + 1, end));
// }

// Console.Clear();

// Console.Write("Введите M: ");
// int m = int.Parse(Console.ReadLine());
// Console.Write("Введите N: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine(PrintNumbers(m, n));


// // int start = 1;   //  Решение через While

// // while(start <= n){
// //     Console.Write($"{start ++} ");
// // }


// // for (int start = 1; start < n; start++)  // Решение через For
// // {
// //     Console.Write($"{start ++} ");
// // }


//  Напишите программу, которая принимает на вход число и возвращает сумму его цифр с помощью рекурсии.

// Console.Clear();
// Console.Write("Введите число: ");
// int n = int.Parse(Console.ReadLine());

// Console.WriteLine(($"{n} --> {SumNumbers(n)}"));

// int SumNumbers(int number){
//     if(number == 0) return 0;
//     return (number % 10 + SumNumbers(number / 10));
// }


//  Напишите программу, которая на вход принимает два числа A и B, и возводит число A в целую степень B c помощью рекурсии

// int Pow(int number, int rank){
//     // if(rank == 0) return 1;
//     if(rank == 1) return number;
//     return (number * Pow(number,rank - 1));
// }

// Console.Clear();
// Console.Write("Введите число: ");
// int m = int.Parse(Console.ReadLine()); 
// Console.Write("Введите степень: ");
// int n = int.Parse(Console.ReadLine()); 

// Console.WriteLine($"{Pow(m, n)}");


//  

