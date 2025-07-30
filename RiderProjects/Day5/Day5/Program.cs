using System;

class Program
{
    static void Main()
    {
        Say();
        Console.WriteLine(Method(10));
        Console.WriteLine(Methoddd(5, 3));
    }
    static void Say()
    {
        Console.WriteLine("Привіт");
    }

    static int Method(int x)
    {
        return 5 + x;
    }

    static int Methoddd(int a, int b)
    {
        return a + b;
    }

   
}