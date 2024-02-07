int[] numbers = { -4, 3, 4, 1 };

System.Console.WriteLine("введите число: ");
int input = int.Parse(Console.ReadLine());

for (int i = 0; i < numbers.Length; i++)
{
    if (input == numbers[i])
    {
        System.Console.WriteLine("Да");
     return;
}
}  
System.Console.WriteLine("Нет");