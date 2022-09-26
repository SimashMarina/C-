/* Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
Например:   4; массив [6, 7, 19, 345, 3] -> нет
            -3; массив [6, 7, 19, 345, 3] -> да */

Console.Clear();
Console.WriteLine("Задайте размер массива");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Введите искомое число: ");
int number = int.Parse(Console.ReadLine());
int[] array = new int[size];
string result = "Нет";
var newRnd = new Random();
for (int i = 0; i < size; i++)
{
    array[i] = newRnd.Next(-99, 100);
    Console.Write(array[i] + " ");
}

Console.WriteLine();

for (int i = 0; i < size; i++)
{
    if (array[i] == number) result = "Да";
}
Console.WriteLine(result);




// if (i == number)
// {
//     Console.WriteLine("Да");
// }
// else
// {
//     Console.WriteLine("Нет");
// }