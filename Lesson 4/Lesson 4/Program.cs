using System.Security.Cryptography.X509Certificates;

class Counter
{
    public delegate void CountMethod();
    public event CountMethod Stoptocount;
    public void Count()
    {
        for(int i = 0; i < 100; i++)
        {
            if (i == 77)
            {
                Stoptocount();
            }
        }
    }
}

class Handler1
{
    public void Message1()
    {
        Console.WriteLine("Пора действовать, ведь уже 77");
    }

}
class Handler2
{
    public void Message2()
    {
        Console.WriteLine("Уже 77, давно пора было начать!");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Counter Tocount = new Counter();
        Handler1 Handler_1 = new Handler1 ();
        Handler2 Handler_2 = new Handler2 ();
        Tocount.Stoptocount += Handler_1.Message1;
        Tocount.Stoptocount += Handler_2.Message2;
        Tocount.Count();
    }
}