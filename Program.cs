﻿//Задача 1
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

// Console.Write("Введите первое число:");
// int numberOne = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int numberTwo = Convert.ToInt32(Console.ReadLine());

// if (numberOne>numberTwo)
// {
// Console.Write("Максимальное число:");
// Console.WriteLine(numberOne);
// Console.Write("Минимальное число:");
// Console.WriteLine(numberTwo);
// }
// else
// {
// Console.Write("Максимальное число:");
// Console.WriteLine(numberTwo);
// Console.Write("Минимальное число:");
// Console.WriteLine(numberOne);
// }
//-------------------------------------------
//Задача 2
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22
// Console.Write("Введите первое число:");
// int numberOne = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите второе число:");
// int numberTwo = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите третье число:");
// int numberThree = Convert.ToInt32(Console.ReadLine());

// if (numberOne > numberTwo && numberOne > numberThree)
// {
//     Console.Write("Максимальное число:");
//     Console.WriteLine(numberOne);
// }
// if (numberTwo > numberOne && numberTwo > numberThree)
// {
//     Console.Write("Максимальное число:");
//     Console.WriteLine(numberTwo);
// }
// if (numberThree > numberTwo && numberThree > numberOne)
// {
//     Console.Write("Максимальное число:");
//     Console.WriteLine(numberThree);
// }
// // --------------------------------------
// Задача 3:
//  Напишите программу, которая на вход принимает число и выдаёт,
// является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет
// Console.Write("Введите число:");
//  int number = Convert.ToInt32(Console.ReadLine());

//  if ( number%2==0){
//     Console.Write("Число является четным!");
//  }
//  else {
//     Console.Write("Число НЕ является четным!");
//  }
// Задача 4:
//  Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Введите число N:");
int N= Convert.ToInt32(Console.ReadLine());
for (int x = 2; x < N; x++)       
if (x%2==0)            
Console.WriteLine(x);
