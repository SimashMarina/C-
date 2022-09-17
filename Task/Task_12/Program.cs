/*Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число
кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.
34, 5 -> не кратно, остаток 4 16, 4 -> кратно  */
Console.Write("Введите первое число :");
int number1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число :");
int number2 = int.Parse(Console.ReadLine());
int result = number1 % number2;
if (number1 > number2)
{
    if (result == 0)
    {
        Console.WriteLine("Числа кратно");
    }
    else
    {
        Console.WriteLine($"Число не кратно, остаток = {result}");
    }
}
else
{
    Console.WriteLine("Число не делится");
}