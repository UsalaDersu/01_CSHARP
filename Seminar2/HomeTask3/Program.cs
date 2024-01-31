int a = 100;
int b = a/10;
int c = a%10;

if (a>=10 & a<=99)
{
    if (b>c)
    {
        System.Console.WriteLine(b);
    }
    else
    {
        System.Console.WriteLine(c);
    }
}
else
{
    System.Console.WriteLine("введите номер от 10 до 99");
}

