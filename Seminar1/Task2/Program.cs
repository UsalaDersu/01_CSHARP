int n = -3;

if (n < 0)
{
    n = -n;
}
int i = -n;
while (i <= n)
{
    System.Console.Write(i);
        System.Console.Write(' ');
        i = i + 1;
}
