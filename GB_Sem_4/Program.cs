//  1.Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.

// int sumToNum(int num)
// {
//     int sum = 0;
//     for (int i = 1; i <= num; i++)
//     {
//         sum += i;
//     }
//     return sum;
// }

// Console.Write("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Sum of elements is " + sumToNum(7));


//  2.Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.

// int countnumbers(int num){
    
//     int count = 0;
    
//     while(num > 0){
//         num = num / 10;
//         count++;
//     }
//     return(count);
// }

// Console.Write("Введите целое число: ");
// int numbers = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(countnumbers(numbers));


//  3.Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

// int miltiplayToNum(int num)
// {
//     int miltiplay = 1;
//     for (int i = 1; i <= num; i++)
//     {
//         miltiplay *= i;
//     }
//     return miltiplay;
// }

// Console.Write("Введите целое число: ");
// int numbers = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(miltiplayToNum(numbers));


//  4.напишите программу,которая выводит массив из 8 элементов, заполненный нолями и единицами в случайном порядке. 

//  создаем массив случайных чисел, где size -- количество элементов в массиве, min -- начало диапазона генерации случайных чисел, от какого генерируем, max -- до какого генерируем

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }

// //  создаем массив из чисел, которые вводим вручную.
// int[] CreateArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++)
//     {
//         Console.Write("Input " + i + " element: ");
//         array[i] = Convert.ToInt32(Console.ReadLine());
//     }
//     return array;
// }

// // выводим значения элементов массива в одну строку через пробел
// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// int[] myRandomArray = CreateRandomArray(8, 0, 1);
// ShowArray(myRandomArray);

