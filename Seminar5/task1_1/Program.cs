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

int[,] ReplaceEvenIndexedNumbersWithSquares(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 & j % 2 == 0)
            {
                array[i, j] = array[i, j] * array[i, j];
            }
        }
    }
    return array;
}

int[,] array = GetArray(4, 4);
PrintArray(array);
ReplaceEvenIndexedNumbersWithSquares(array);
System.Console.WriteLine();
PrintArray(array);
