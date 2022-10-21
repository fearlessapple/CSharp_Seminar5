Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "");
Console.Write("Задайте минимальное значение эл-та массива: ");
int minValue = int.Parse(Console.ReadLine() ?? "");
Console.Write("Задайте максимальное значение эл-та массива: ");
int maxValue = int.Parse(Console.ReadLine() ?? "");

int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(" ", array));
SumElements(array);

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void SumElements(int[] array)
{
    double sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
        else
        {
            sum = sum + 0;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Сумма нечётных эл-тов массива: {sum + array[0]}");
}