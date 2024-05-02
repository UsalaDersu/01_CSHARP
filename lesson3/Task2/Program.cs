// Задача - вывод на экран квадрата чисел
void PrintSquares(int n) // название функции - печать квадрата.void означает, что она ничего не возвращает. Функция просто считает.
{
    int i = 1; //
    while (i <= n)
    {
        System.Console.Write($"{i * i} ");
        i++;// операция ++ заменяет = i+1
    }
}
PrintSquares(5);
//PrintSquares(10);
//PrintSquares(15);