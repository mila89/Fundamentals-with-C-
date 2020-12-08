using System;

namespace Login
{
    class Program
    {
        static void Main()
        {
            string username = Console.ReadLine();
            string password = "";
            for (int i = username.Length-1; i >=0 ; i--)
            {
                password = password + username[i].ToString();
            }
            string input = Console.ReadLine();
            int counter = 0;
            do
            {
                counter++;
                if (input == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (counter==4)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else if (input!=password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    input = Console.ReadLine();
                }
                
            }
            while (input != password || counter<4);
        }
    }
}
