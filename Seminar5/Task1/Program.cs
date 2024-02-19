int[,] CreateMatrix(int rowCount, int colomsCount) // функция для создания масства рандомных целых чисел
{
    int[,] matrix = new int[rowCount, colomsCount];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

int[,] GetArray(int rows, int cols)
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
int Sum(int[,] array)
{
    int sum = 0; 
        for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
    }
    return sum;
}
int[,] array = GetArray(4, 2);
int[,] array2 = GetArray(2, 3);
int[,] array3 = GetArray(2, 8);

PrintArray(array);
PrintArray(array2);
PrintArray(array3);

System.Console.WriteLine(Sum(array));
System.Console.WriteLine(Sum(array2));
System.Console.WriteLine(Sum(array3));