using System;

namespace TUT1_Question2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int shift;
            double hours, rate, regular_pay, overtime_pay, total_pay, retirement_deduction, net_pay;

            // Prompt user for input
            Console.WriteLine("Select shift number below:");
            Console.WriteLine("    1 for first shift");
            Console.WriteLine("    2 for second shift");
            Console.WriteLine("    3 for third shift");
            Console.Write("Enter the shift number: ");
            shift = Convert.ToInt32(Console.ReadLine());

            // If user inputs invalid shift number, the user tries again
            while (shift > 3)
            {
                Console.WriteLine("Invalid shift number.");
                Console.Write("Enter the shift number: ");
                shift = Convert.ToInt32(Console.ReadLine());
            }

            // Determine hourly rate based on shift
            switch (shift)
            {
                case 1:
                    rate = 23.0;
                    break;
                case 2:
                    rate = 24.5;
                    break;
                case 3:
                    rate = 29.0;
                    break;
                default:
                    Console.WriteLine("Invalid shift number.");
                    return;
            }

            Console.Write("Enter the number of hours worked: ");
            hours = Convert.ToDouble(Console.ReadLine());

            // Calculate regular pay
            if (hours <= 40)
            {
                regular_pay = hours * rate;
                overtime_pay = 0.0;
            }
            else
            {
                regular_pay = 40.0 * rate;
                overtime_pay = (hours - 40.0) * (rate * 1.5);
            }


            // Calculate retirement deduction
            retirement_deduction = 0;
            if (shift != 1)
            {
                Console.Write("Would like to participate in the retirement plan? (y/n): ");
                string response = Console.ReadLine();
                retirement_deduction = response == "y" ? 0.03 * (regular_pay + overtime_pay) : 0.0;
            }

            // Calculate net pay
            total_pay = regular_pay + overtime_pay;
            net_pay = total_pay - retirement_deduction;

            // Display results
            Console.WriteLine("Hours worked: {0}", hours);
            Console.WriteLine("Shift: {0}", shift);
            Console.WriteLine("Hourly rate pay: {0:C}", rate);
            Console.WriteLine("Regular pay: {0:C}", regular_pay);
            Console.WriteLine("Overtime pay: {0:C}", overtime_pay);
            Console.WriteLine("Total pay: {0:C}", total_pay);
            Console.WriteLine("Retirement deduction: {0:C}", retirement_deduction);
            Console.WriteLine("Net pay: {0:C}", net_pay);

            _ = Console.ReadKey();
        }
    }

}
