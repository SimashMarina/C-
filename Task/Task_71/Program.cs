/*  В некотором машинном алфавите имеются четыре буквы «а», «и», «с»
и «в». Покажите все слова, состоящие из n букв, которые можно построить из
букв этого алфавита.
n = 2 -> аа, ии, сс, вв, аи, иа, ис, си, ас, са,
ав, ва, ви, ив, св, вс */

int n = int.Parse(Console.ReadLine());
char[] word = { 'а', 'и', 'с', 'в' };

void GetWord(char[] array, int num, int i)
{
    if (i < array.Length) return;
    Console.Write($"{array[i]}{array[i + 1]}");
    GetWord(array, num, i + 1);
}

GetWord(word, n, 0);