/* Напишите программу, которая принимает
на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5 */

/* Console.Write("Введите натуральное число ");
int num = int.Parse(Console.ReadLine());

if (num < 0) num = num * -1;

int GetNumbers(int number)                               // метод int  который что то возвращает
{
    int div = 1;
    int count = 0;
    while (number > div)
    {
        div = div * 10;
        count++;
    }
    return count;
}
int count = GetNumbers(num);
Console.WriteLine($"Колличество чисел в числе {num} = {count}"); */



Console.Write("Введите натуральное число ");
int num = int.Parse(Console.ReadLine());
int count = 0;

while (num != 0)
{
    num = num / 10;
    count++;
}
Console.WriteLine(count);