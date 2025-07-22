using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть а: ");
        int a = int.Parse(Console.ReadLine());
        Console.WriteLine("Введіть b: ");
        int b = int.Parse(Console.ReadLine());

        if (a > 0 && b > 0)
        {
            Console.WriteLine("Так ці числа більше нуля");
        }

        if (a < 0 || b < 0)
        {
            Console.WriteLine("Щось одне менше нуля");
        }

        if (!(a != b))
        {
            Console.WriteLine("І ще");
            Console.WriteLine("А дорівнює B");
        }
    }
}