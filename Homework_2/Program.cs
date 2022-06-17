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
    while(num >= 1000){
    num = num / 10;
    }
    if(num < 100) Console.WriteLine(" Третья цифра отсутствует ");
    if(num >=100 && num < 1000) Console.WriteLine(" Третья цифра: " + (num = num % 10));
}

Console.Write(" Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());      

Numresult(num);

      
      








    
    










