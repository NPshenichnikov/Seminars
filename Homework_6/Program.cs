//  Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.


// Console.WriteLine("Введите числа через запятую: " +  { ;}; );
// int[] array = {3,54,767,3,5,65,};

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

// void ShowArray(int[] array)
// {
//     for(int i = 0; i < array.Length; i++){
//         Console.Write(array[i] + " ");
//     }
// }

// int[] MyArray = CreateArray(5);

// ShowArray(MyArray);


//  Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

int res = 0;
int i = 0;
int[] MyArray = new int[res];

while(num  >= 1){
    if(num % 2 != 0){
       MyArray[i] = 0;
    }   
        
    else{
       MyArray[i] = 1;
    }
    num = num / 2;
    res++;
    i++;
}

void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

ShowArray(MyArray);

// void SwapArray(int[] array){
//     int buf = 0;

//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         buf = array[i];
//         array[i] = array [array.Length - i - 1];
//         array[array.Length - i - 1] = buf; 
//     }
    
//     // ShowArray(array);
// }

// Console.WriteLine();

// SwapArray(MyArray);





// //  Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// Console.WriteLine("Введите значение b1: ");
// double x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение k1: ");
// double x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение b2: ");
// double x = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите значение k2: ");
// double x = Convert.ToInt32(Console.ReadLine());

// if(k1 * x + b1 == k2 * x + b2){
//     Console.WriteLine("Прямые совпадают")
// }

// if()




//  Задача 44: Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.

// Console.Write("Введите число N: ");
// int num = Convert.ToInt32(Console.ReadLine());

// // if(num >= 2)
// // Console.Write(0 + " " + 1);

// int res1 = 0;
// int res2 = 0;
// int sum = 0;
// int i = 0;

// while(i < num){
//     sum = sum1 + sum2;
//     Console.Write(sum + " ");
//     sum = sum + 2 * sum;
//     i++;


// }


