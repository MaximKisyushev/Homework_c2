// Задача 13: Напишите программу, которая выводит третью цифру заданного числа
// или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите целое число: ");
string number = Console.ReadLine();

if (number.Length >= 3) Console.WriteLine($"{number[2]} - третья цифра числа {number}");
else Console.WriteLine($"В числе {number} нет третьей цифры");

//2 вариант
// Console.WriteLine("Введите целое число: ");
// int number = Convert.ToInt32(Console.ReadLine());

// if (number / 100 <= 0) Console.WriteLine("Третьей цифры нет");
// else if (number / 1000000000 > 0) Console.WriteLine((number/10000000)%10);
// else if (number / 100000000 > 0) Console.WriteLine((number/1000000)%10);
// else if (number / 10000000 > 0) Console.WriteLine((number/100000)%10);
// else if (number / 1000000 > 0) Console.WriteLine((number/10000)%10);
// else if (number / 100000 > 0) Console.WriteLine((number/1000)%10);
// else if (number / 10000 > 0) Console.WriteLine((number/100)%10);
// else if (number / 1000 > 0) Console.WriteLine((number/10)%10);
// else if (number / 100 > 0) Console.WriteLine(number%10);