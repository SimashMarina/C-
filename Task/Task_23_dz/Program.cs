/* Напишите программу, которая принимает на
вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 4, 9.
5 -> 1, 8, 27, 64, 125
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */
Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int number = 1;
while (number <= num)
{
    Console.WriteLine($"Число {number,5} | Куб {number * number * number,5}");
    number++;
}
Console.WriteLine("Конец");