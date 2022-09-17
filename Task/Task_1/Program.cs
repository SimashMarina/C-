// Console.WriteLine ("Является ли первое число квадратом второго?");
Console.Write("Введите число a: ");
int numA = int.Parse(Console.ReadLine());
Console.Write("Введите число b: ");
int numB = int.Parse(Console.ReadLine());
// Console.Write("Квадрат числа равен: ");
int numResult = numA * numA;
if (numResult == numB)
{
    Console.WriteLine("Да");
}
else 
{
    Console.WriteLine("Нет");
}