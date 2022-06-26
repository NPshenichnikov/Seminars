// Примеры форматирования.

// string name = "Имя";
// int age = 99;
// Console.WriteLine("Имя:{0} Возраст: {1}", name, age);


// int number = 23;
// string result = string.Format("{0:f}", number);
// Console.WriteLine(result);


// double number2 = 45.08;
// string result2 = string.Format("{0:f1}", number2);
// Console.WriteLine(result2);


// string name = "Имя";
// int age = 99;
// Console.WriteLine($"Имя: {name} Возраст: {age}");


// int x = 8;
// int y = 7;
// string result = $"{x} + {y} = {x + y}";
// Console.WriteLine(result);


// string name = "Имя";
// int age = 99;

// Console.WriteLine($"Имя: {name, -10} Возраст: {age}");// пробелы после
// Console.WriteLine($"Имя: {name, 15} Возраст: {age}");// прбелы до\



//   1. Задайте массив из 12 элементов,заполненный случайными числами из промежутка [-9, 9].Найдите сумму отрицательных и положительных элементов массива.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(min,max+1);
//     }
//     return array;
// }
 
// void ShowArray(int[] array){
    
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// int[] myArray = CreateRandomArray(12, -9, 9);
// ShowArray(myArray);

// int sumPos = 0;
// int sumNeg = 0;

// for (int i = 0; i < myArray.Length; i++)
// {
//     if(myArray[i] > 0) 
//         sumPos += myArray[i];
//     else
//         sumNeg += myArray[i];    
// }

// Console.WriteLine($"Сумма положительных: {sumPos}. Сумма отрицательных: {sumNeg}");


//  Задача 32:Напишите программу,на замену элементов массива: положительные элементы замените на отрицательные,и наоборот.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(-100, 101);
//     }
//     return array;
// }

// int[] GetArray(int[]array){
//     for (int i = 0; i < array.Length; i++)
//     {
//         array[i] = array[i] * (-1);
//     //     array[i] *= -1;
//     }
//     return array;
// }
// void ShowArray(int[] array){
    
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// int[] array = CreateRandomArray(10);
// ShowArray(array);
// Console.WriteLine();
// ShowArray(GetArray(array));


//  Задача 33: Задайте массив.Напишите программу,которая определяет,присутствует ли заданное число в массиве.

// int[] CreateRandomArray(int size)
// {
//     int[] array = new int[size];
//     for(int i = 0; i < size; i++){
//         array[i] = new Random().Next(-20,21);
//     }
//     return array;
// }

// int[] ArrayNum = CreateRandomArray(10);
    
// void ShowArray(int[] array){
    
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// ShowArray(ArrayNum);

// Console.Write("Введите искомое число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// int ArrayCheck(int[] array){
//      for (int i = 0; i < ArrayNum.Length; i++)
//      {
//         if(ArrayNum[i] == num) return 1;
//      }

//      return 0;
// }   
   
// if(ArrayCheck(ArrayNum) == 1) Console.Write("-> Да");

// if(ArrayCheck(ArrayNum) == 0) Console.Write("-> Нет");








