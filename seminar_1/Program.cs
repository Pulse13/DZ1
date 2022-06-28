Console.WriteLine("Введите три числа: ");
int f = Convert.ToInt32(Console.ReadLine());
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (f>a && f>b)
{
    Console.WriteLine("max = " + f);
}
else
{
    if (a>b)
    {
        Console.WriteLine("max = " + a);
    }
    else
    {
        Console.WriteLine("max = " + b);
    }
}