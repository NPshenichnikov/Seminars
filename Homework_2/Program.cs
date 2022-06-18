// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// void Numresult(int num){
//     if(num > 100 && num < 1000){
//     num = num / 10 % 10;
//        Console.WriteLine(" Вторая цифра этого числа: " + num);
//     }
//     else{
//        Console.WriteLine(" Введите корректное число!!!");
//     }
// }

// Console.Write(" Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());

// Numresult(num);


// 2. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

void Numresult(int num){
    while(num > 999){
    num = num / 10;
    }
    if(num < 100) Console.WriteLine(" Третья цифра отсутствует ");
    if(num >=100 && num < 1000) Console.WriteLine(" Третья цифра: " + (num = num % 10));
}

Console.Write(" Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());      

Numresult(num);

      
 //   3. Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.   

// void Weekend(int day){
// if(day == 6 || day == 7) Console.WriteLine(" Ура!!!Выходной!!! ");
// if(day > 0 && day < 6) Console.WriteLine(" Рабочий день( ");
// if(day < 1 || day > 7) Console.WriteLine(" Некорректное число ");
// }   

// Console.Write("Введите число дня недели: ");
// int day = Convert.ToInt32(Console.ReadLine());

// Weekend(day);
