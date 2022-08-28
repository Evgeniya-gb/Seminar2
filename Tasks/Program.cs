//  Задача 10: Напишите программу, которая принимает на вход трёхзначное число 
//  и на выходе показывает вторую цифру этого числа.

// Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string stringNumber = Convert.ToString(num);
// Console.WriteLine("Второй цифрой данного числа является: "+stringNumber[1]);

// Задача 15: Напишите программу, которая принимает на вход цифру, 
//  обозначающую день недели, и проверяет, является ли этот день выходным.

// Console.Write("Введите цифру(от 1 до 7), обозначающую день недели: ");
// int day_of_the_week = Convert.ToInt32(Console.ReadLine());

// void Checking_Day_Of_The_Week (int day_of_the_week) 
// {
//     if (day_of_the_week == 6 || day_of_the_week == 7) {
//   Console.WriteLine("Данный день является выходным. ");
//   }
//   else if (day_of_the_week < 1 || day_of_the_week > 7) 
//   {
//     Console.WriteLine("Ошибка ввода. Данный день не является днем недели.");
//   }
//   else Console.WriteLine("Данный день не является выходным. ");
// }
// Checking_Day_Of_The_Week(day_of_the_week);

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа 
// или сообщает, что третьей цифры нет.

// Console.Write("Введите цифру: ");
// int num = Convert.ToInt32(Console.ReadLine());
// string numText = Convert.ToString(num);
// if (numText.Length > 2)
// {
//   Console.WriteLine("третьей цифрой данного числа является: " + numText[2]);
// }
// else 
// {
//   Console.WriteLine(" нет третьей цифры");
// }