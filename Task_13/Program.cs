// Задача 13: Напишите программу, которая выводит третью цифру 
// заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 100) Console.WriteLine($"{num} -> третьей цифры нет");
if (num > 100) Console.WriteLine($"{num} -> {ThreeNumber(num)}");

int ThreeNumber(int number)
{
    if (number < 1000) return number % 10;
    else
    {
        while (number > 1000)
        {
            int count = number / 10;
            number = count;
        }
        return number % 10;
    }
}