/* Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8 */

Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число B: ");
int b = int.Parse(Console.ReadLine());

Number(a, b, 0, 1);
void Number(int numA, int numB, int count, int result)
{
    if (count == numB)
    {
        Console.WriteLine(result);
        return;
    }
    result *= numA;
    count++;
    Number(numA, numB, count, result);
}