/* int[,] matrix = new int[3, 5];

Random rnd = new Random();

for (int i = 0; i < matrix.GetLength(0); i++) // позволяет пройти по строкам, идет запрос количества строк 
{
    for (int j = 0; j < matrix.GetLength(1); j++) // 2 цикл осуществляет проход по переменным массива - тут идет запрос столбца 1
    {
        matrix[i, j] = rnd.Next(1, 11);
    }
}
for (int i = 0; i < matrix.GetLength(0); i++) // позволяет пройти по строкам, идет запрос количества строк 
{
    for (int j = 0; j < matrix.GetLength(1); j++) // 2 цикл осуществляет проход по переменным массива - тут идет запрос столбца 1
    {
        System.Console.Write($"{matrix[i, j]} "); // такой вывод называется интерполяция строк
    }
    System.Console.WriteLine();
} */

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

void ShowMatrix(int[,] matrix) // функция для вывода матрицы на экран
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} "); // такой вывод называется интерполяция строк
        }
        System.Console.WriteLine();
    }
}
int[,] matrix = CreateMatrix(4, 2);
ShowMatrix(matrix);