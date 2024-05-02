
   // Рекурсивная функция для вывода элементов массива в обратном порядке
void PrintArrayReverseRecursive(int[] array, int index)
{
    if (index >= 0)
    {
        Console.Write($"{array[index]} ");
        PrintArrayReverseRecursive(array, index - 1); // Рекурсивный вызов
    }
}

        // Создаем массив и заполняем его случайными числами
int[] array = { 1, 2, 5, 0, 10, 34 };

        // Выводим сгенерированный массив
Console.WriteLine("Сгенерированный массив:");
Console.WriteLine("[" + string.Join(", ", array) + "]");

        // Выводим элементы массива в обратном порядке (рекурсивно)
Console.WriteLine("Элементы массива в обратном порядке (рекурсивно):");
PrintArrayReverseRecursive(array, array.Length - 1); // Начинаем с последнего элемента
Console.WriteLine(); // Переходим на новую строку после вывода

// ответ:
// Сгенерированный массив:
// [1, 2, 5, 0, 10, 34]
// Элементы массива в обратном порядке (рекурсивно):
// 34 10 0 5 2 1