// Напишите программу, которая на вход принимает 2 числа и проверяет, является ли одно число квадратом другого.
// 5, 25 -> да
// -4. 16 -> да
// 25, 5 -> да
// 8, 9 -> нет.
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());

bool res = b == a * a || a == b * b;
Console.WriteLine(res ? "Да" : "Нет");