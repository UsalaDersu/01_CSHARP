int n = 10;
int[] array = { 5, 5, 5, 7, 1, 35, 1, 3, 1, 5 };
int i = 0;
while (i < n)
{ if (array[i]%2==0)
{
    System.Console.Write($"{array[i]} ");
}
    i = i + 1;
}
 System.Console.WriteLine("нет четных чисел");