/* Напишите программу, которая принимает на вход трёхзначное число 
и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());

// int number = new Random().Next(100, 1000); Console.WriteLine(number); // для проверки

int num1 = number / 10;
int result = num1 % 10;

Console.WriteLine(result);