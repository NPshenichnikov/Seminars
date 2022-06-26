//  Задача 25: Напишите цикл,который принимает на вход два числа (А и В) и возводит число А в натуральную степень В.

// Console.Write("Введите целое число А: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите натуральное число B: ");
// int b = Convert.ToInt32(Console.ReadLine());

// int result = 1;
// int count = 1;

// if (a == 0) Console.WriteLine("Ошибка! Число А должно быть неравно 0");
// if (b <= 0) Console.WriteLine("Ошибка! Число B должно быть больше 0");

// if (b > 0 && a != 0){
//    while(count <= b){
//    count = count + 1;
//    result = result * a;
//    }
//    Console.WriteLine(" Ответ: " + result );
// }


//   Задача 27: Напишите программу,которая принимает на вход число и выдаёт сумму цифр в числе.

// int SumNumber(int num){

//     int result = 0;
//     int sum = 0;

//     while (num > 0){
//         result = num % 10;
//         sum = sum + result;
//         num = num / 10;
//     }
//     return sum;
// }     

// Console.Write("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.Write(SumNumber(number));


//  Задача 29: Напишите программу,которая задаёт массив из 8 элементов и выводит их на экран.



// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// int[] MyArray = CreateRandomArray(8, -20, 21);

// void ShowArray(int[] array){
    
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// ShowArray(MyArray);


