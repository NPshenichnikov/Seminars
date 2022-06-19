//  Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void Quarters(int x, int y){
//     if(x == 0 || y == 0) Console.WriteLine("Нет возможности определить четверть");
//     else{
//         if (x > 0 && y > 0) Console.WriteLine("1 четверть");
//         if (x < 0 && y > 0) Console.WriteLine("2 четверть");
//         if (x < 0 && y < 0) Console.WriteLine("3 четверть");
//         if (x > 0 && y < 0) Console.WriteLine("4 четверть");
//     }
// }

// Console.Write("Введите координату X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// Quarters(x, y);


// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).

// void Quarters(int num){
//     if (num > 4 || num < 1) Console.WriteLine(" Некорректное число "); 
//     if (num == 1) Console.WriteLine(" x > 0, y > 0 ");
//     if (num == 2) Console.WriteLine(" x < 0, y > 0 ");
//     if (num == 3) Console.WriteLine(" x < 0, y < 0 ");
//     if (num == 4) Console.WriteLine(" x > 0, y < 0 ");
// }

// Console.Write("Введите число четверти: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Quarters(num);


// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

// Console.Clear();
// double Segment(int x1, int y1, int x2, int y2){
//     return Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));
// }

// Console.Write("Введите координату X1: ");
// int xA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y1: ");
// int yA = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату X2: ");
// int xB = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите координату Y2: ");
// int yB = Convert.ToInt32(Console.ReadLine());

// double res = Math.Round(Segment(x1:xA, y1:yA, x2:xB, y2:yB),2);
// Console.WriteLine("Длина отрезка: " + res);





