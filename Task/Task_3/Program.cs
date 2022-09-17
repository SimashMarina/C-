Console.Write("Введие целое число: ");
int N = int.Parse(Console.ReadLine());
int Y = -N;
while (Y <= N)
{
    Console.Write(Y + ", ");
    Y++;
}