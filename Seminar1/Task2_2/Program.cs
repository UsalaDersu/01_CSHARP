Console.Write("Enter a number: ");
int n = int.Parse(Console.ReadLine());

for (int i = -n; i <= n; i++)
{
    System.Console.Write(i + " ");
}

Console.ReadKey();