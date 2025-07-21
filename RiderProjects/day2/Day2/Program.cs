using System;

class Program
{
    static void Main()
    {
        string correctLogin = "admin";
        string correctPassword = "12345";
        
        Console.Write("Введіть логін: ");
        string userLogin = Console.ReadLine();
        
        if (userLogin == correctLogin)
        {
            Console.Write("Введіть пароль: ");
            string userPassword = Console.ReadLine();
            
            if (userPassword == correctPassword)
            {
                Console.WriteLine(" Вхід успішний. Ласкаво просимо!");
            }
            else
            {
                Console.WriteLine(" Невірний пароль.");
            }
        }
        else
        {
            Console.WriteLine(" Невірний логін.");
        }

        Console.WriteLine("Натисніть будь-яку клавішу для виходу");
        Console.ReadKey();
    }
}
