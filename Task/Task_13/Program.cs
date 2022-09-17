/* Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6 */

Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

if (n > 99)
{
    Console.WriteLine(n.ToString()[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}