// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и 
// на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

int SecondNumber(int number)
{
    return (number % 100) / 10;
}

Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100 || num > 999) Console.WriteLine("Введено некорректное число! Требуется ввести трехзначное число!");
if (num > 99 && num < 1000) Console.WriteLine($"{num} -> {SecondNumber(num)}");


