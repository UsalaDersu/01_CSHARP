//Задайте одномерный массив, заполненный случайными числами. 
//Определите количество простых чисел в этом массиве. 
//Примеры [1 3 4 19 3] => 2 [4 3 4 1 9 5 21 13]  => 3

bool IsPrime(int number)

{
    for (int i = 2; i < number; i++)
    {
        if (number % i == 1)
        {
            return false;
        }
    }
    return true;
}

int[] GetRandomArray(int size, int minValue, int maxValue)
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

int[] GetArrayFromConsole()
{
    System.Console.WriteLine("Size:");
    int size = int.Parse(Console.ReadLine()!);
    int[] array = new int[size];
    System.Console.WriteLine($"Enter {size} elements:");
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int CountPrimeNumbers(int[] array)
{
    int count = 0;
    foreach (var elem in array)
    {
        if (IsPrime(elem))
        {
            count = count + 1;
        }
    }
    return count;
}

int[] array = GetRandomArray(6, 1, 99);
PrintArray(array);
int[] array2 = GetArrayFromConsole();
PrintArray(array2);

System.Console.WriteLine($"Результат 1:{CountPrimeNumbers(array)}");
System.Console.WriteLine($"Результат 2:{CountPrimeNumbers(array2)}");

/*Random random = new Random();
int[] array = new int[3]; // Пример размера массива

// Заполнение массива случайными числами
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(1, 10); // Генерируем случайное число от 1 до 100
}

Console.WriteLine("Сгенерированный массив:");
foreach (var number in array)
{
    System.Console.WriteLine(number + " ");
}


*/






