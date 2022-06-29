//  1.Напишите программу,которая перевернет одномерный массив.Последний элемент будет на первом месте,а первый на последнем.

// int[] CreateRandomArray(int size, int min, int max)
// {
//     int[] array = new int[size];
//     for (int i = 0; i < size; i++)
//     {
//         array[i] = new Random().Next(min, max + 1);
//     }
//     return array;
// }

// int[] arr = CreateRandomArray(7, -50, 50);


// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
// }

// ShowArray(arr);

// void SwapArray(int[] array){
//     int buf = 0;

//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         buf = array[i];
//         array[i] = array [array.Length - i - 1];
//         array[array.Length - i - 1] = buf; 
//     }
    
//     ShowArray(array);
// }

// Console.WriteLine();

// SwapArray(arr);


//  2.Напишите прогарамму,которая принимает на вход три числа,и проверять :может ли существовать треугольник со сторонами такой длинны.

// Если вводим целые числа:

// Console.WriteLine("Введите число стороны A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число стороны B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите число стороны C: ");
// int C = Convert.ToInt32(Console.ReadLine());

// if (A < B + C && B < A + C && C < A + B) Console.WriteLine("Такой треугольник существует!!!");
    
// else{
//     Console.WriteLine("Такой треугольник не существует!!!");
// }


// Если вводим рендомные дробные числа от 0 до 0.99999999:

// bool NewNum(double A, double B, double C){

//     if (A < B + C && B < A + C && C < A + B){
//         return true;
//     }
//     else{
//         return false;
//     }
// }

// double A = new Random().NextDouble();
// Console.WriteLine("{0:f3}", A);

// double B = new Random().NextDouble();
// Console.WriteLine("{0:f3}", B);

// double C = new Random().NextDouble();
// Console.WriteLine("{0:f3}", C);

// if (true)
// {
//     Console.WriteLine("Такой треугольник существует!!!");
// }

// else{
//     Console.WriteLine("Такой треугольник не существует!!!");
// }

// NewNum(A, B, C);





