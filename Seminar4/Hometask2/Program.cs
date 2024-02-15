//Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] ThreeDigitRandomArray(int size, int minValue, int maxValue)
{
    int[] array = new int[size];
    Random rnd = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(minValue, maxValue + 1);
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
int CountEvenNumbers(int[] array)
{
    int count = 0;
    foreach (var e in array)
    {
        if (e % 2 == 0)
        {
            count = count + 1;
        }
    }
    return count;
}

int[] array = ThreeDigitRandomArray(6, 100, 999);
PrintArray(array);
System.Console.WriteLine($"Четных чисел в массиве: {CountEvenNumbers(array)}");