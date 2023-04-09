using System;

namespace TUT1_Question1
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int[] stock = new int[10];

            // Prompt user to input 10 integers
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Enter integer #{0}: ", i + 1);
                try
                {
                    stock[i] = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} Please enter an integer.", ex.Message);
                    i--; // decrement i to repeat this iteration
                }
            }

            // Find and display highest and lowest values
            int highestValue = stock[0];
            int lowestValue = stock[0];
            for (int i = 1; i < 10; i++)
            {
                //Finding the highest value
                if (stock[i] > highestValue)
                {
                    highestValue = stock[i];
                }
                //Finding the lowest value
                if (stock[i] < lowestValue)
                {
                    lowestValue = stock[i];
                }
            }
            Console.WriteLine("The highest stock value is: {0}", highestValue);
            Console.WriteLine("The lowest stock value is: {0}", lowestValue);

            _ = Console.ReadKey();
        }
    }
}
