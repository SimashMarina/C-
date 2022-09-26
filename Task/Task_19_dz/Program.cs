/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
23432 -> да
12821 -> да */

// Универсальная программаz
Console.WriteLine("Введите число");
var n = (Console.ReadLine());
if (n.Reverse().SequenceEqual(n)) Console.WriteLine("Палиндром");
else
{
    Console.WriteLine("Не палиндром");
}

// рабочая версия с массивом для 5 чисел

/* Console.WriteLine("Введите размерность массива = ");
int n = int.Parse(Console.ReadLine());
int[] massiv = new int[n];

for (int i = 0; i < n; i++)
{
    Console.Write(i + " элемент = ");
    massiv[i] = int.Parse(Console.ReadLine());
}
if (massiv[4] == massiv[0] & massiv[3] == massiv[1]) // (пока не разобрался как сделать универсально)
    if (massiv[index] == massiv[index2])
    {
        Console.WriteLine("Число является палиндромом");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом");
    } */
    