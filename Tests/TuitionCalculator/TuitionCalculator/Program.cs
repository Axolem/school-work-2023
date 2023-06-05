using System;

namespace TuitionCalculator
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            //Declere none changing variables
            const int MAX_YEARS = 7;
            const int FOUR_MONTHS = 10;
            const int TWELVE_MONTHS = 12;

            //Declare variables
            int numberOfMonths;
            string studentName;
            double tuitionFee;

            //Initialise random
            Random randomNumberGenerator = new Random();

            //Prompt for user input name
            Console.Write("Enter name or STOP to exit...: ");
            studentName = Console.ReadLine();

            //Terminate the program if 'STOP' entered
            if (studentName == "STOP")
            {
                Environment.Exit(0);
            }

            //prompt for user input for tuition  
            Console.Write("Enter monthly tuition fee: R ");
            tuitionFee = double.Parse(Console.ReadLine());

            //Display the name
            Console.WriteLine("Leaner: {0}", studentName);

            //Iterate for the 7 year to calculate each year's fee
            for (int i = 1; i <= MAX_YEARS; i++)
            {
                //etermine the number of months the parent will be at a time in the range of 1 to 12.
                numberOfMonths = randomNumberGenerator.Next(1, 12 + 1);

                //Calculate if the parent pays quarterly
                if (numberOfMonths == 4)
                {
                    tuitionFee -= (tuitionFee * FOUR_MONTHS / 100);
                    Console.WriteLine("Grade {0} {1} Number of payments = {2}", i, $"{tuitionFee:C}", numberOfMonths);
                }
                //Calculate if the parent pays yearly
                else if (numberOfMonths == 12)
                {
                    tuitionFee -= (tuitionFee * TWELVE_MONTHS / 100);
                    Console.WriteLine("Grade {0} {1} Number of payments = {2}", i, $"{tuitionFee:C}", numberOfMonths);
                }
                //For any other months display the current tuition
                else
                {
                    Console.WriteLine("Grade {0} {1} Number of payments = {2}", i, $"{tuitionFee:C}", numberOfMonths);
                }
            }

            //Hold the program to close on any key press
            Console.ReadKey();
        }
    }
}
