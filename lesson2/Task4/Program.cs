int n = 5;
int[] array = { 0, 2, 100, 4, 200 };
int max = array[0];
int i = 0;

while (i < n)
{
if (array[i] > max)
{
max = array[i];
}
i = i + 1;
}
System.Console.WriteLine(max);


max = array[0];
for (int j = 0; j < n; j++)
{
   if (array[j] > max)
    {
    max = array[j];
    }
}
System.Console.WriteLine(max);

max = array[0];
foreach (var e in array)
{
    if (e > max)
    {
    max = e;
    }
}
System.Console.WriteLine(max);