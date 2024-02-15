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
void ReverseArray(int[] arr)
{
int left = 0;
int right = arr.Length - 1;
    while (left < right)
        {
        int temp = arr[left];
        arr[left] = arr[right];
        arr[right] = temp;
        left++;
        right--;
        }
    }

int[] array = ThreeDigitRandomArray(6, 1, 100);
PrintArray(array);
ReverseArray(array); // Вызываем функцию ReverseArray для разворота массива
PrintArray(array); // Печатаем развернутый массив