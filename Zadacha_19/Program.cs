Console.Clear();

System.Console.WriteLine("Enter number from 10000 to 99999: ");
int a = int.Parse(System.Console.ReadLine());

if ((a>=10000)&(a<=99999))
{

    if (((a/10000)%10)==((a/1)%10))
    {
        if (((a/1000)%10)==((a/10)%10)) System.Console.WriteLine("Yes");
    }
    else System.Console.WriteLine("No");
    
}
else System.Console.WriteLine("No");