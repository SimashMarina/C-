// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// например: 7 -> 28     4 -> 10    8 -> 36  



/* Console.Write("Введите натуральное число ");
int num = int.Parse(Console.ReadLine());

int GetSumNumbers(int number)                               // метод int  который что то возвращает
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    return sum;
}

int sumResult = GetSumNumbers (num);
Console.WriteLine($"Сумма чисел от 1 до {num} = {sumResult}"); */


// не корректный метод который не рекомендуется использовать
Console.Write("Введите натуральное число ");
int num = int.Parse(Console.ReadLine());

void GetSumNumbers(int number)                              // метод void  который не возвращает ничего
{
    int sum = 0;
    for (int i = 1; i <= number; i++)
    {
        sum = sum + i;
    }
    Console.WriteLine($"Сумма чисел от 1 до {num} = {sum}");
}

GetSumNumbers(num);