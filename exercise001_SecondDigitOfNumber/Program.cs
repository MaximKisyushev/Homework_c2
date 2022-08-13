// **Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает
// вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.WriteLine("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int secondDigit = (number / 10) % 10;

if (number / 100 > 0 && number / 100 <= 9) Console.WriteLine($"{number} -> {secondDigit}");
else Console.WriteLine("Введено не трёхзначное число");