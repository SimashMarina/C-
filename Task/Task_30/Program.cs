// // Напишите программу, которая
// выводит массив из 8 элементов, заполненный
// нулями и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

Console.Write("Введите размерность массива = ");
int n = int.Parse(Console.ReadLine());
int[] massiv = new int[n];

void FillMassiv(int [] col1)
{
    int lenFill = col1.Length;
    int index = 0;
    while (index < lenFill)
    {
        col1[index] = new Random().Next(0, 2);
        Console.Write($" {col1[index]}");
        index++;
    }
}
FillMassiv(massiv);