// Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int a = 0;
int b = 1;
Console.WriteLine("Введите сколько символов отобразить от числа Фибоначи");
int n = int.Parse(Console.ReadLine());
Console.Write(a + " " + b + " ");
int sum = 0;
for (int i = 0; i < n + 1; i++)
{
    sum = a + b;
    Console.Write(sum + " ");
    a = b;
    b = sum;
}


// Решение на семинаре, возможно, некорректное.


/* Console.WriteLine("Введите сколько символов отобразить от числа Фибоначи");
int numN = int.Parse(Console.ReadLine());

int numA = 0;
int numB = 1;
int result = 0;
if (numN > 2)
{
    if (numN > 3)
    {
        Console.Write(numA +" "+ numB + " ");

        for (int i = 0; i <= numN; i++)
        {
            result = numA + numB;
            numA = numB;
            numB = result;
            i++;
            Console.Write($"{result + " "}");
        }
    }
    else
    {
        result = numA + numB;
        Console.WriteLine($"{numA}{numB}{result:1}");
    }
}
else
{
    Console.Write("Ошибка: Введите число больше 2");
}
 */