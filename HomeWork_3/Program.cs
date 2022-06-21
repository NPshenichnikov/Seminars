//  Задача 19:Напишите программу,которая принимает на вход пятизначное число и проверяет,является ли оно палидромом.

// void Polydrome(int num){

//     if(num < 10000 || num >99999) Console.WriteLine("Некорректное число");

//     else{
//         if((num / 10000 == num % 10) && (num / 1000 % 10 == num % 100 / 10))
//             Console.WriteLine("Число является палиндромом");
//         else{
//             Console.WriteLine("Число не является палиндромом");
//         }
//     }
// }

// Console.Write(" Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Polydrome(num);


//  Задача 21:Напишите программу,которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// Console.Clear();
// double LengthSeg(int x1, int y1, int z1, int x2, int y2, int z2){
//     return Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2) + Math.Pow((z2 - z1),2));
// }

// Console.Write("Введите координату X1: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y1: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z1: ");
// int zA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату X2: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y2: ");
// int yB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Z2: ");
// int zB = Convert.ToInt32(Console.ReadLine());

// double res = Math.Round(LengthSeg(x1:xA, y1:yA, x2:xB, y2:yB, z1:zA, z2:zB),2);
// Console.WriteLine("Длина отрезка: " + res);


//  Задача 23:Напишите программу,которая принимает на вход число N и выдаёт таблицу кубов чисел от 1 до N(включительно).

// void CubeNumbers(int n){

//     int count = 1;

//     Console.Write(n + " -> ");

//     if (n > 0){
//         while (count <= n){
//             Console.Write(Math.Pow(count, 3) + ", ");
//             count++;
//         }    
//     }   
//     if (n < 2){
//         while (count >= n){
//             Console.Write(Math.Pow(count, 3) + ", ");
//             count--;
//         }        
//     }
// } 

// Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// CubeNumbers(number);
