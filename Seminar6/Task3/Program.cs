//Задайте произвольную строку. Выясните, является ли она палиндромом.

Console.WriteLine("Введите строку для проверки на палиндром:");
string inputString = Console.ReadLine();

string reversedString = ReverseString(inputString);
bool isPalindrome = (inputString == reversedString);

Console.WriteLine($"Исходная строка: {inputString}");
Console.WriteLine($"Перевернутая строка: {reversedString}");
Console.WriteLine($"Является ли палиндромом? {(isPalindrome ? "Да" : "Нет")}");

// Функция для переворота строки
string ReverseString(string input)
{
    char[] charArray = input.ToCharArray(); // Преобразуем строку в массив символов
    Array.Reverse(charArray); // Разворачиваем массив символов
    return new string(charArray); // Преобразуем массив символов обратно в строку
}
