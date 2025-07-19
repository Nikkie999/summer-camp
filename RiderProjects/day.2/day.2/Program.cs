using System;

class Program
{
    static void Main()
    {
        string correctLogin = "Nikkie";
        string correctPassword = "12345";

        Console.Write("Введіть логін: ");
        string login = Console.ReadLine();

        if (login != correctLogin)
        {
            Console.WriteLine("Невірний логін");
        }
        else
        {
            Console.Write("Введіть пароль: ");
            string password = Console.ReadLine();

            if (password != correctPassword)
            {
                Console.WriteLine("Невірний пароль");
            }
            else
            {
                Console.WriteLine("Вхід дозволено");
            }
        }
    }
}