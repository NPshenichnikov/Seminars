// // 9.Напишите программу,которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа.

// void ShowNumber(){
//     int num = new Random().Next(10,100);
//     int firstNum = num / 10;
//     int secondNum = num %10;
//     Console.Write(num + " => ");
//     if (firstNum > secondNum){
//         Console.WriteLine(firstNum);
//     }
//     else{
//         Console.WriteLine(secondNum);
//     }
// }
// ShowNumber();


// 11.Напишите программу,которая выводит случайное трёхзначное число и удаляетвторую цифру этого числа.

// int NumberWithoutSecDig(int Number){
//     int NewNumber = 0;
//     NewNumber = Number / 100 * 10 + Number % 10;
//     return NewNumber;
// }
// int Number = new Random().Next(100,1000);
// int a = NumberWithoutSecDig(Number);
// Console.WriteLine(Number + " " + a);


//  12.Напишите программу,которая будет принимать на вход два числа и выводить,является ли второе число кратным первому.Если число 2 не кратно числу 1,то программа выводит остаток от деления.


// void ResultNum(int num1, int num2){
//     if(num2 % num1 == 0){
//     Console.WriteLine(num2 + " кратно " + num1);
//     }
//     else{
//     Console.WriteLine(num2 + " не кратно " + num1 + ", остаток - " + num2 % num1);
//     }
// }

// Console.Write("input first number : ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("input second number : ");
// int num2 = Convert.ToInt32(Console.ReadLine());

// ResultNum(num1, num2);


//  14.Напишите программу,которая принимает на вход число и проверяет,кратно ли оно одновременно 7 и 23.


void Result(int num){
    if(num % 7 == 0 && num % 23 == 0)
        Console.WriteLine(num + " кратно 7 и 23");
    else{
        Console.WriteLine(num + " не кратно 7 и 23");
    }
}

Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());

Result(num);
