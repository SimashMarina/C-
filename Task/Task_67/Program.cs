/* Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9 */

Console.WriteLine("Введите натуральное число");
int n = int.Parse(Console.ReadLine());

GetSum(n, 0);

void GetSum(int num, int sum)
{
    if (num == 0)
    {
        Console.WriteLine(sum);
        return;
    }

    sum = sum + num % 10;
    num = num / 10;
    GetSum(num, sum);
}