// double CalculateFormula(int a, int b, int c, int d)
// {
//     double numenator = a * b;
//     int denomenator = c + d;
//     double result = numenator / denomenator;
//     return result;
// }

//     double result = CalculateFormula(1, 2, 3, 4);
//     System.Console.WriteLine(result);

float CalculateFormula(int a, int b, int c, int d) //double - число с точкой ( нецелое), int -только целое
{
float numenator = a * b;
int denomenator = c + d;
float result = numenator / denomenator;
return result;
}
float result = CalculateFormula(1, 2, 3, 4);
System.Console.WriteLine(result);