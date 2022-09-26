/* Напишите программу, которая будет создавать
копию заданного массива с помощью поэлементного
копирования. */

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int[] array = new int[size];
int[] newArray = new int[size];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 20);
}
for (int i = 0; i < array.Length; i++)
{
    newArray[i] = array[i];
}
Console.WriteLine($"{string.Join(' ', array)}");
Console.WriteLine($"{string.Join(' ', newArray)}");