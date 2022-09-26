/* Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N. */

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());

void Num(int num)
{
    if (num == 0) return;
    Num(num - 1);
    Console.Write($"{num} ");
}

Num(num);