using System;

namespace LoginSwitch
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
            int loginAttempts = 1;
            enteredPassword = Console.ReadLine();
            if (loginAttempts<4){
                    switch (enteredPassword)
                    {
                        case var wrongpass when enteredPassword != password:
                            Console.WriteLine("Incorrect password. Try again.");
                            loginAttempts++;
                            break;
                        case var correctpass when enteredPassword == password:
                            Console.WriteLine($"User {username} logged in.");
                            return;
                    }
                    
            }
            enteredPassword = Console.ReadLine();
            switch (loginAttempts)
            {
                case < 4:
                    switch (enteredPassword)
                    {
                        case var wrongpass when enteredPassword != password:
                            Console.WriteLine("Incorrect password. Try again.");
                            loginAttempts++;
                            break;
                        case var correctpass when enteredPassword == password:
                            Console.WriteLine($"User {username} logged in.");
                            return;
                    }
                    break;
            }
            enteredPassword = Console.ReadLine();
            switch (loginAttempts)
            {
                case < 4:
                    switch (enteredPassword)
                    {
                        case var wrongpass when enteredPassword != password:
                            Console.WriteLine("Incorrect password. Try again.");
                            loginAttempts++;
                            break;
                        case var correctpass when enteredPassword == password:
                            Console.WriteLine($"User {username} logged in.");
                            return;
                    }
                    break;
            }
            enteredPassword = Console.ReadLine();
            switch (loginAttempts)
            {
                case 4:
                    switch (enteredPassword)
                    {
                        case var wrongpass when enteredPassword != password:
                            Console.WriteLine($"User {username} blocked!");
                            return;
                        case var correctpass when enteredPassword == password:
                            Console.WriteLine($"User {username} logged in.");
                            return;
                    }
                    break;
            }
        }
    }
}
