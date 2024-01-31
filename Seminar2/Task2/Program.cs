int a = 487;
int b = (a % 100) / 10;
int c = a % 10;
double result = Math.Pow(b, c);
System.Console.WriteLine(result);