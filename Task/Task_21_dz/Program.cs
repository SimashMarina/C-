/* Напишите программу, которая принимает на
вход координаты двух точек и находит расстояние между
ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */
Console.WriteLine("Введите координаты точки A: ");
int numA1 = int.Parse(Console.ReadLine());
int numA2 = int.Parse(Console.ReadLine());
int numA3 = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты точки B: ");
int numB1 = int.Parse(Console.ReadLine());
int numB2 = int.Parse(Console.ReadLine());
int numB3 = int.Parse(Console.ReadLine());
int n1 = numA1 - numB1;
int n2 = numA2 - numB2;
int n3 = numA3 - numB3;

double result = Math.Sqrt(n1 * n1 + n2 * n2 + n3 * n3);
double n = Math.Round(result, 2);
Console.WriteLine($"Расстояние между точками =  {n}");