Console.Clear();


int Read(string arg)
{
    int num;
    System.Console.WriteLine($"input {arg}: ");
    while ((!int.TryParse(System.Console.ReadLine(), out num)))
    {
        System.Console.WriteLine("Not a number");
    }
    return num;
}

double Length()
{
    int x1 = Read("x1");
    int y1 = Read("y1");
    int z1 = Read("z1");
    int x2 = Read("x2");
    int y2 = Read("y2");
    int z2 = Read("z2");
    double L = Math.Round((Math.Sqrt(Math.Pow(x1-x2,2)+Math.Pow(y1-y2,2)+Math.Pow(z1-z2,2))),3);
    return L;
}

void Answ()
{
    double L = Length();
    System.Console.WriteLine($"Vector length = {L}");
}

Answ();