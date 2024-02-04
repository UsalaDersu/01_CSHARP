int number = 81;

string numberString = number.ToString();

Console.WriteLine("Цифры числа по порядку:");

// Перебираем каждый символ (цифру) в строке и выводим его
for (int i = 0; i < numberString.Length; i++)
{
    Console.Write(numberString[i] + " ");
}

Console.WriteLine(); //