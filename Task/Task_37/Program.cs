// Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3     [6 7 3 6] -> 36 21


Console.Write("Введите размер массива :");
int size = int.Parse(Console.ReadLine());

int[] num = new int[size];

var newRnd = new Random();
for (int i = 0; i < size; i++)
{
    num[i] = newRnd.Next(-10, 10);
    Console.Write(num[i] + " ");
}
Console.WriteLine();

int[] res = new int[num.Length / 2];

for (int i = 0; i < res.Length; i++)
{
    res[i] = num[i] * num[num.Length - 1 - i];
    Console.Write(res[i] + " ");
}





// Не доработанный код!

/* bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Задайте размер массива");
    int size = int.Parse(Console.ReadLine());
    int[] array = new int[size];
    int count = 0;
    var newRnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = newRnd.Next(0, 1000);

        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != array.Length[i])
            count = i;

    }
    Console.WriteLine(count);
    Console.WriteLine("Попробуем еще раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
} */