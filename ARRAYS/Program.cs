using System;

namespace ARRAYS
{
    class Program
    {
        static void Main(string[] args)
        {
            string userContinue = "y";
            int[] numbers = { 2, 8, 0, 24, 51 };

            while(userContinue == "y")
            {
                int index = GetUserInput("Enter the index of the array: ");
                if (index > numbers.Length || index < 0)
                {
                    Console.WriteLine("Index is out of bounds.  Please enter another value between 0 and " + (numbers.Length - 1));
                    index = int.Parse(Console.ReadLine());

                }
                Console.WriteLine("The value at index " + index + " is " + numbers[index]);
                userContinue = Continue("Do you want to enter another index? (y/n)").ToLower();

                if (userContinue == "n")
                {
                    Console.WriteLine("Have a great day!");
                }
            }

            Console.ReadKey();
            
        }
        public static int GetUserInput(string message)
        {
            Console.WriteLine(message);
            int input = int.Parse(Console.ReadLine());
            return input;
        }

        public static string Continue(string message)
        {
            Console.WriteLine(message);
            string userContinue = Console.ReadLine();
            return userContinue;
        }
    }
}
