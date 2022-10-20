Console.Write("Задайте размер массива: ");
int size = int.Parse(Console.ReadLine() ?? "");

int[] array = GetArray(size, 100, 999);
Console.WriteLine(String.Join(" ", array));
ArrayCheck(array);


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

void ArrayCheck(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            sum = sum + 1;
        }
        else
        {
            sum = sum + 0;
        }  
    }
    Console.Write($"Чётных чиселв массиве: {sum}");
}