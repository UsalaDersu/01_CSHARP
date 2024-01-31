int x = 4;
int y = -2;
if (x > 0 & y > 0)
{
    System.Console.WriteLine(" координата находится в 1 четверти");
}
else
{
    if (x < 0 & y > 0)
    {
        System.Console.WriteLine(" координата находится в 2 четверти");
    }
    else
    {
        if (x < 0 & y < 0)
        {
            System.Console.WriteLine(" координата находится в 3 четверти");
        }
      else
      {
        if (x > 0 & y < 0)
        {
            System.Console.WriteLine(" координата находится в 4 четверти");
        }
        else
        {
            System.Console.WriteLine(" координата находится на осях");
        }
      }
}
}
