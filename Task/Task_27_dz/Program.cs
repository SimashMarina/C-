// Напишите программу, которая принимает на
// вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

/* Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine());
int sum = 0;
while (n > 0)
{
    int num = n % 10;
    sum = sum + num;
    n = n / 10;
}
Console.WriteLine($"Сумма цифр равна: {sum}"); */


// Решение с помощью метода

Console.Write("Введите число N: ");
int num = int.Parse(Console.ReadLine());

int SumNumber(int num)
{
    int num1 = 0;
    int sum = 0;

    for (int i = 0; i < num; i++)
    {
        num1 = num % 10;
        sum = sum + num1;
        num = num / 10;
    }
    return sum;
}

int sumNum = SumNumber(num);
Console.WriteLine("Сумма цифр в числе: " + sumNum);