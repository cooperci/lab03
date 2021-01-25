using System;

namespace lab03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a whole number between 1 and 100: ");
            int userInput = Int32.Parse(Console.ReadLine());
            if (userInput % 2 == 0)
            {
                if (userInput <= 25)
                {
                    Console.WriteLine("Even and less than 25");
                }
                else
                {
                    Console.WriteLine("Even");
                }
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
    }
}
