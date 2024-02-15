//Напишите программу, которая бесконечно запрашивает целые числа с консоли. 
//Программа завершается при вводе символа ‘q’ или при вводе числа, сумма цифр которого чётная.
class Program
{
    static void Main(string[] args)
    {

Console.WriteLine("Введите целые числа. Для завершения введите 'q' или число с суммой цифр, которая является чётной.");

        while (true)
        {
            int number = ReadNumberFromConsole();

            if (number == 0)
                continue;

            if (IsEvenSumOfDigits(number))
            {
                Console.WriteLine($"Сумма цифр числа {number} чётная. Программа завершена.");
                break;
            }
        }
    }

    static int ReadNumberFromConsole()
    {
        Console.Write("Введите число: ");
        string input = Console.ReadLine();

        if (input.ToLower() == "q")
        {
            Console.WriteLine("Программа завершена.");
            Environment.Exit(0); // Завершение программы
        }

        return int.Parse(input);
    }

    static bool IsEvenSumOfDigits(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum % 2 == 0;
    }
}