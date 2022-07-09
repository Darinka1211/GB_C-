// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
int NumberEx(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }

    return result;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = NumberEx(numberA, numberB);
Console.WriteLine("Ответ: " + exponentiation);

//   Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{
    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
Console.Write("Введите ряд чисел, разделенных запятой : ");
string? NumberOut = Console.ReadLine();

NumberOut = NumberOut + ",";
string RemovingSpaces(string series)
{
    string newString = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ')
        {
            newString += series[i];
        }
    }
    return newString;
}
void СheckNumber2(int series)
{
    if (
        series == '0'
        || series == '1'
        || series == '2'
        || series == '3'
        || series == '4'
        || series == '5'
        || series == '6'
        || series == '7'
        || series == '8'
        || series == '9'
        || series == ','
        || series == '-'
    ) { }
    else
    {
        Console.WriteLine($"Ошибка ввода  символа. Вводи цифры.");
    }
}

int[] ArrayOfNumbers(string newString)
{
    int[] arrOfNumbers = new int[1];
    int j = 0;
    for (int i = 0; i < newString.Length; i++)
    {
        string newString1 = "";

        while (newString[i] != ',' && i < newString.Length)
        {
            newString1 += newString[i];
            СheckNumber2(newString[i]);
            i++;
        }
        arrOfNumbers[j] = Convert.ToInt32(newString1);
        if (i < newString.Length - 1)
        {
            arrOfNumbers = arrOfNumbers.Concat(new int[] { 0 }).ToArray(); 
        }
        j++;
    }
    return arrOfNumbers;
}
void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}

string newString = RemovingSpaces(NumberOut);

int[] arrOfNumbers = ArrayOfNumbers(newString);

PrintArry(arrOfNumbers);
