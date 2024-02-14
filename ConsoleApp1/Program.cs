using System;

class Program
{
    static void Main()
    {
        int n = 0; 

        while (n < 1 || n >= 10)
        {
            Console.Write("Enter a number below 10: ");
            string userInput = Console.ReadLine();
            //So I used int.TryPrase here, which will check wether the input is valid integer or not and if it's return false then the program will prompt the user to enter a valid number.
            if (int.TryParse(userInput, out n) && n > 0 && n < 10)
            {
                break;
            }
            else
            {
                Console.WriteLine(" Enter a valid number below 10.");
            }
        }

        for (int i = 1; i <= 9; i++)
        {
            int result = i * n;
            Console.WriteLine($"{i} x {n} = {result}");


        }
    }
}