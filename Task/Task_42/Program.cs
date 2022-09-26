// Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

bool run = true;
while (run)
{
    Console.Clear();
    Console.WriteLine("Введите целое число: ");
    int num = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите основание системы счисления: ");
    int baseNum = int.Parse(Console.ReadLine());

    // int result = 0;
    // int d10 = 1;

    // while (num != 0)
    // {
    //     result = result + num % baseNum * d10;
    //     num /= baseNum;   // num = num / 2;
    //     d10 *= 10;
    // }
    // Console.WriteLine(result);

void DecToOther (int n, int baseN)
{
    if (n == 0) return;
    DecToOther (n / baseN, baseN);
    Console.Write (n % baseN);
}
                                                            // Метод с рекурсией
DecToOther(num, baseNum);

    Console.WriteLine();
    Console.WriteLine("Пробуем еще раз? y/n");
    run = Console.ReadKey().Key == ConsoleKey.Y;
}