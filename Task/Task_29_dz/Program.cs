// Напишите программу, которая задаёт массив целых чисел и выводит их на экран.
// Размер массива определяется пользователем

Console.WriteLine("Введите размерность массива = ");
int n = int.Parse(Console.ReadLine());
int[] array = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write(i+1 + " элемент = ");
    array[i] = int.Parse(Console.ReadLine());
}
var str = string.Join(" ", array);
Console.WriteLine(str);