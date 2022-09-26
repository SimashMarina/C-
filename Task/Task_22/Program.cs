Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
int number = 1;
while (number <= num)
{
    Console.WriteLine($"Число {number,5} | Квадрат {number * number,5}");
    number++;
}
Console.WriteLine("Конец");