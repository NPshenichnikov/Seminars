// 1. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

void Numresult(int num){
    if(num > 100 && num < 1000){
    num = num / 10 % 10;
       Console.WriteLine(" Вторая цифра этого числа: " + num);
    }
    else{
       Console.WriteLine(" Введите корректное число!!!");
    }
}

Console.Write(" Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

Numresult(num);





