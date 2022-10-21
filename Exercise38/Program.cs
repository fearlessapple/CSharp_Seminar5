Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "");
Console.Write("Задайте минимальное значение эл-та массива: ");
int minValue = int.Parse(Console.ReadLine() ?? "");
Console.Write("Задайте максимальное значение эл-та массива: ");
int maxValue = int.Parse(Console.ReadLine() ?? "");

int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(" ", array));

MaxElement(array);
MinElement(array);

int Diff = MaxElement(array) - MinElement(array);
Console.WriteLine($"Разница между максимальным и минимальным: {Diff}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int MaxElement(int[] array)
{
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
    }
    return max;
}

int MinElement(int[] array)
{
    int min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}
