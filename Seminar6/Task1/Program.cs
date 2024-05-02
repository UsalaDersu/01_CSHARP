//Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.
char[,] charArray = {
            {'a', 'b', 'c'},
            {'d', 'e', 'f'}
        };
string resultString = "";

for (int i = 0; i < charArray.GetLength(0); i++)
{
    for (int j = 0; j < charArray.GetLength(1); j++)
    {
        resultString += charArray[i, j]; // Добавляем символ к строке
    }
}
Console.WriteLine(resultString);