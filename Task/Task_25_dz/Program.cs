// // Напишите цикл, который принимает на вход
// два числа (A и B) и возводит число A в натуральную
// степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

/* Console.WriteLine("Введите первое число");
double num = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число");
double num2 = double.Parse(Console.ReadLine());

double result = Math.Pow(num, num2);
Console.WriteLine(result); */

// Решение с помощью метода

int Expon(int numberA, int numberB)
{
    int res = 1;
    for (int i = 1; i <= numberB; i++)
    {
        res = res * numberA;
    }
    return res;
}

Console.Write("Введите число A: ");
int numberA = int.Parse(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = int.Parse(Console.ReadLine());

int expon1 = Expon(numberA, numberB);
Console.WriteLine($"{numberA} в степени {numberB} = {expon1}");