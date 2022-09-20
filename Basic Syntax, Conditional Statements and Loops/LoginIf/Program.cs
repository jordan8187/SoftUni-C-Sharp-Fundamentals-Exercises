using System;

namespace LoginIf
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = string.Empty;
            string enteredPassword = string.Empty;
            for (int i = username.Length - 1; i >= 0; i--)
            {
                char reverseLetter = username[i];
                password += reverseLetter;
            }
            for (int loginAttempts = 0; loginAttempts < 4; loginAttempts++)
            {
                enteredPassword = Console.ReadLine();
                if (enteredPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    return;
                }
                else
                {
                    if (loginAttempts < 3)
                    {
                        Console.WriteLine("Incorrect password. Try again.");

                    }
                    else
                    {
                        Console.WriteLine($"User {username} blocked!");

                    }
                }
            }
        }

    }
}
