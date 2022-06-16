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

void ShowNumber(){
    int Newnumber = new Random().Next(100,1000);