﻿//Считать с консоли строку, состоящую из цифр и латинских букв. 
//Сформировать новую строку, состоящую из букв исходной строки.

//Этапы решения:
//Ввод строки 
//Проход по элементам строки 
//Проверка элемента: является ли он буквой?

string GetLettersFromString(string s) // aeполучить буквы (принимает на вход строку S)
{
    string letters = ""; // строковая переменная буквы, которая хранит буквы из строки, но сейчас букв нет - она пустая
    foreach (char e in s) // изменять элементы строки мы не можем - поэтому foreach
    {
        if (char.IsLetter(e) == true)// нам нужно проверить, является ли e буквой. Методы, начинающиеся на Is - такие методы проверяют входящий символ на какой то критерий// выбранный     метод проверяет , входит ли символ в кодировку ASCII и является ли буквой.ASCII - это стандарт кодирования знаков латинского алфавита, цифр, занков препинания, управляющих символов (типа NULL -пустой,Backspace - возврат на шаг и тп. )
        {
            letters = letters + e; //если переменная является буквой, то к строке добавляется эта буква
        }
    }
    return letters; // 
}

string str = Console.ReadLine();//создаем строковую переменную и поместим в нее значение с консоли
string result = GetLettersFromString(str);// вызываем функцию , передадим ей на вход параметр str
System.Console.WriteLine(result);// вызываем результат на экран

