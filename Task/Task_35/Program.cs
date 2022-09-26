// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


bool run = true;
while (run)
{
    Console.Clear();
    int[] array = new int[123];
    int count = 0;
    var newRnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = newRnd.Next(0,1000);

        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < array.Length; i ++)
    {
        if (array[i] > 9 && array[i] < 100)
        count += 1;
    }
    Console.WriteLine(count);
    Console.WriteLine("Попробуем еще раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}