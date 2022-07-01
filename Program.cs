//Задача 1
// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Введите первое число:");
int numberOne = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число:");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne>numberTwo)
{
Console.Write("Максимальное число:");
Console.WriteLine(numberOne);
Console.Write("Минимальное число:");
Console.WriteLine(numberTwo);
}
else
{
Console.Write("Максимальное число:");
Console.WriteLine(numberTwo);
Console.Write("Минимальное число:");
Console.WriteLine(numberOne);
}