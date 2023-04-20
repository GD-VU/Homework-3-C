Console.Clear();

Numbers(Read());

int Read()
{
    System.Console.WriteLine("Enter number: ");
    int N = int.Parse(System.Console.ReadLine());
    return N;
}

void Numbers(int N)
{
    int n = 1;
    while (n<=N)
    {
        double d = Math.Pow(n,3);
        System.Console.Write($"{d} ");
        n++;
    }
}