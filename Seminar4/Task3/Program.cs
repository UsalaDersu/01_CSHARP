int GetRandomArrayFromConsole()
{
    System.Console.Write("Enter Size<8: ");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(0, 10);
    }
    return array;
}

void PrintArray(int[] array)
{
    System.Console.Write("[");
    foreach (var number in array)
    {
        System.Console.Write(number + " ");
    }
    System.Console.WriteLine("]");
}


int ConvertNumbersToInt(int[] array)
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        int tempResult = array[i] * (int)Math.Pow(10, array.Length - i - 1);
        result += tempResult;
    }
    //System.Console.Write($"{tempResult}");
    return result;
}

int[] array = GetRandomArrayFromConsole();
PrintArray(array);
System.Console.WriteLine(ConvertNumbersToInt(array));