
int[,] GetArray(int rows, int cols)// еще один вариант  под функция для создания масства рандомных целых чисел
{
    int[,] table = new int[rows, cols];
    Random rnd = new Random();

    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            table[i, j] = rnd.Next(1, 11);
        }
    }
    return table;
}

void PrintArray(int[,] array) // функция для вывода матрицы на экран
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]} "); // такой вывод называется интерполяция строк
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

int SumOfDiagonalNumbers(int[,] array)
{
    int sum = 0;
    //int minLength = array.GetLength(0);
    int minLength = Math.Min(array.GetLength(0), array.GetLength(1));
    if (array.GetLength(1) < array.GetLength(0))
    {
        minLength = array.GetLength(1);
    }

    for (int i = 0; i < minLength; i++)
    {
        {
            sum = sum + array[i, i];
        }
    }
    return sum;
}

int[,] array = GetArray(5, 2);
PrintArray(array);
int sum = SumOfDiagonalNumbers(array);
System.Console.WriteLine(sum);