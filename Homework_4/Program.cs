//  Задача 25: Напишите цикл,который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

Console.Write("Введите целое число А: ");
int a = Convert.ToInt32(Console.ReadLine());
if(a == 0) Console.WriteLine("Ошибка.Число А должно быть неравно 0");
Console.Write("Введите натуральное число B: ");
int b = Convert.ToInt32(Console.ReadLine());
if(b <= 0) Console.WriteLine("Ошибка.Число B должно быть больше 0");
int result = a * a;
int count = 3;

if(b > 0 && a != 0){
   while(count <= b){
   count = count + 1;
   result = result * a;
   }
   Console.WriteLine(" Ответ: " + result );
}

// if(a == 0) Console.WriteLine("Ошибка.Число А должно быть неравно 0");
// if(b <= 0) Console.WriteLine("Ошибка.Число B должно быть больше 0");









//   Задача 27: Напишите программу,которая принимает на вход число и выдаёт сумму цифр в числе.









//  Задача 29: Напишите программу,которая задаёт массив из 8 элементов и выводит их на экран.
