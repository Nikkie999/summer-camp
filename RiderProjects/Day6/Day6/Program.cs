using System;

class Program
{
    static void Main()
    {
        PrintNumbers(1, 5);
        Print(5);
    }

    static void PrintNumbers(int digital, int max)
    {
        if (digital > max)
        {
            return;
        }

        Console.WriteLine(digital);
        PrintNumbers(digital + 1, max);
    }

    static void Print(int number)
    {
        if (number < 1)
        {
            return;
        }

        Console.WriteLine(number);
        Print(number - 1);
    }
}