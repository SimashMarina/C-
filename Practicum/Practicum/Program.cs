// 1. Создание
// 2. Заполнение
// 3. Главная задача
// 4. печать массива

int[] CreateArray(int count)
{
    return new int[count];
}

void Fill(int[] array)
{
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        array[i] = new Random().Next(1, 10);
    }
}


string Print(int[] array)
{
    string res = String.Empty;
    int len = array.Length;
    for (int i = 0; i < len; i++)
    {
        res += $"{array[i]}";
    }
    return res;
}






int[] MainExample(int[] inputArray)
{
    int len = 0;
    int count = inputArray.Length;

    for (int k = 0; k < count; k++)
    {
        if (inputArray[k] % 2 == 0) len++;
    }

    int[] outputArray = new int[len];
    int i, index;
    index = i = 0;

while(i < count)
{
    if(inputArray[i] % 2 == 0)
    {
        outputArray[index] = inputArray[i];
        index++;
    }
    i++;
}

    return outputArray;
}


var ina = CreateArray(10);
Fill(ina);
Console.WriteLine($"ina {Print(ina)}");
var outa = MainExample(ina);

Console.WriteLine($"outa {Print(outa)}");