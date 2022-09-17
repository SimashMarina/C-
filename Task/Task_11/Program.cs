// напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа. Например 456 -> 46.

int number = new Random().Next(100, 1000);
int num1 = number / 100;
// int num2 = number % 10;
int num3 = number % 10;
Console.WriteLine(number);
Console.WriteLine($"Первое число = {num1}");
//Console.WriteLine($"Второе число = {num2}");
Console.WriteLine($"Третье число = {num3}");
Console.WriteLine($"Ответ = {num1*10+num3}");