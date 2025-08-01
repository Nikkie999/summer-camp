using System;

class Program
{
    static void Main()
    {
        // int [] array = new int[5];
        // array[0] = 10;
        // array[1] = 20;
        // array[2] = 30;
        // array[3] = 40;
        // array[4] = 50;
        //
        // Console.WriteLine(array[4]);

        // int[] zxc;
        // int elements = int.Parse(Console.ReadLine());
        // zxc = new int [elements];

        int[] array = new int[5];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = i * 2;
        }

        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }

    }
}
