/* Напишите программу, которая принимает на вход цифру, обозначающую
день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет */

Console.WriteLine("Введите цифру, обозначающую день недели");
int number = int.Parse(Console.ReadLine());
if (0 < number && number < 8)
{
    if (number == 6 || number == 7)
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Введенное число не соответствует дню недели");
}







// Array
Console.WriteLine("Введите число дня недели от 1 до 7: ");
var day = Convert.ToInt32(Console.ReadLine());
string[] isWeekend = {"нет", "нет", "нет", "нет", "нет", "нет", "да", "да"};
if(day > 0 && day < 8)
{
    Console.WriteLine(isWeekend[day -1]);
}
else Console.WriteLine("Вы ввели некорректное значение!");
