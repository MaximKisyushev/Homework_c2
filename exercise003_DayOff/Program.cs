// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Введите число обозначающее день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());

if (dayNumber == 6 || dayNumber == 7) Console.WriteLine($"{dayNumber} день недели - выходной");
else Console.WriteLine($"{dayNumber} день недели - НЕ выходной");