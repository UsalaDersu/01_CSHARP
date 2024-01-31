int a = 487;
int b = (a % 100) / 10;
int c = a % 10;
//double result = Math.Pow(b, c);
//System.Console.WriteLine(result);

int d = 1;

for (int i = 1; i <= c; i++)
{
    d = d * b;
}
System.Console.WriteLine(d);