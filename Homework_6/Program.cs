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

while(num  >= 2){
    if(num % 2 == 0) Console.Write(0 + " ");
    else{
        Console.Write(1 + " ");
    }
    num = num / 2;
    if(num == 3) Console.Write(1 + " " + 1);
    if(num == 1) Console.Write(1 + " ");
}



