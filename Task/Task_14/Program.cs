/* Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно на 7 и 23. например: 14 -> нет, 46 -> нет, 131 -> да. */
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
// int num1 = 7;
// int num2 = 23;

if (number % 7 == 0 & number % 23 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}