Console.WriteLine("Введите номер четверти: ");
int num = int.Parse(Console.ReadLine());
if (num == 1)
{
    Console.WriteLine("Диапазон находится в x > 0, y > 0");
}
else if (num == 2)
{
    Console.WriteLine("Диапазон находится в x < 0, y > 0");
}
else if (num == 3)
{
    Console.WriteLine("Диапазон находится в x < 0, y < 0");
}
else if (num == 4)
{
    Console.WriteLine("Диапазон находится в x > 0, y < 0");
}
else
{
    Console.WriteLine("Некорректное значение, введите число от 1 до 4.");
}