using System;

class Program
{
    static void Main()
    {
        
        for (int i = 1; i <= 5; i++)
        {
            Console.WriteLine($"i = {i}");
        }
        
        int j = 1;
        while (j <= 5)
        {
            Console.WriteLine($"j = {j}");
            j++;
            
        }
        
        int k = 1;
        do
        {
            Console.WriteLine($"k = {k}");
            k++;
           //break;
            //continue;
            
        } while (k <= 5);

        int a = 0;
        Label:
        a++;
        Console.WriteLine($"A = {a}");
        if (a < 5)
        {
            goto Label;
        }
        Console.ReadKey();
    }
}