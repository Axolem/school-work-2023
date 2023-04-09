using System;

namespace TUT1_Question3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int sentinel = 1; // Sentinel to count entered member data
            double total_monthly_contributions = 0; // To store the total monthly contributions of all members

            while (true)
            {
                Console.WriteLine("Enter main member data or (enter 0 to stop): ");
                Console.Write("Member name: ");
                string member_name = Console.ReadLine();

                if (member_name == "0")
                {
                    break; // Exit loop if sentinel is entered
                }

                Console.Write("Age: ");
                int age = Convert.ToInt32(Console.ReadLine());

                Console.Write("Number of adult dependants: ");
                int adult_dependants = Convert.ToInt32(Console.ReadLine());

                Console.Write("Number of child dependants: ");
                int child_dependants = Convert.ToInt32(Console.ReadLine());

                Console.Write("Monthly income: ");
                double monthly_income = Convert.ToDouble(Console.ReadLine());
                Console.Write(" ");

                // Calculate monthly premium
                double monthly_premium = CalculateMonthlyPremium(monthly_income, adult_dependants, child_dependants);

                // Calculate premium penalty
                double premium_penalty = CalculatePremiumPenalty(age, monthly_premium);

                // Add monthly premium and premium penalty to total monthly contributions
                total_monthly_contributions += monthly_premium + premium_penalty;

                // Display member data and monthly contribution
                Console.WriteLine("{0}. {1} ({2} years old) have {3} adult dependant(s) and {4} children, he/she will pay {5:C}/m.",
                    sentinel, member_name, age, adult_dependants, child_dependants, monthly_premium + premium_penalty);

                Console.WriteLine("Monthly Premium (excl. penalties): {0:C}", monthly_premium);
                Console.WriteLine("Premium Penalty: {0:C}", premium_penalty);
                Console.WriteLine("");
                sentinel++;
            }
            Console.WriteLine("");
            Console.WriteLine("====================================================================================");
            Console.WriteLine("");
            Console.WriteLine("Total monthly contributions of all members: {0:C}", total_monthly_contributions);
            Console.WriteLine("");
            Console.WriteLine("====================================================================================");

            _ = Console.ReadLine();
        }

        // Function to calculate monthly premium (excl. penalties)
        private static double CalculateMonthlyPremium(double monthly_income, int adult_dependants, int child_dependants)
        {

            // Pay for first 3 child dependents
            child_dependants = child_dependants <= 3 ? child_dependants : 3;

            double child_premium = monthly_income < 7001
                ? 264 * child_dependants
                : monthly_income > 7000 && monthly_income < 12001
                ? 470 * child_dependants
                : child_dependants * 586;

            double adult_premiun = monthly_income < 7001
                ? 476 * adult_dependants
                : monthly_income > 7000 && monthly_income < 12001
                ? 709 * adult_dependants
                : adult_dependants * 887;

            double main_member = monthly_income < 7001
                ? 582
                : monthly_income > 7000 && monthly_income < 12001
                ? 868
                : 1084;


            double monthlyPremium = child_premium + adult_premiun + main_member;

            return monthlyPremium;
        }

        // Function to calculate premium penalty
        private static double CalculatePremiumPenalty(int age, double monthlyPremium)
        {
            int years_after_35 = age - 35;
            double premium_penalty = years_after_35 <= 4
                ? +monthlyPremium * 0.05
                : years_after_35 >= 5 && years_after_35 <= 14
                    ? +monthlyPremium * 0.15
                    : years_after_35 >= 15 && years_after_35 <= 24 ? +monthlyPremium * 0.25 : +monthlyPremium * 0.35;
            return premium_penalty;
        }
    }
}
