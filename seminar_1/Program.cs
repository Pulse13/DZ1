Console.WriteLine("N: ");
int N = Convert.ToInt32(Console.ReadLine());
int m = 1;
while (m<N)
{
    if (m%2 == 0)
    {
        Console.Write(m + " ");
        m+=1;
    }
    else
    {
        m+=1;
    }
}