using System;

namespace Question2
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // init an instance of  Department
            Department department = new Department();

            // ask user to enter sales data
            Console.WriteLine("Please populate the system with some data...");

            department.populateArray();

            // display the average sales for each department
            double[] avarageSalesD = department.calculateAvgSalesPerDepart();

            Console.WriteLine($"|-----------------------------------------------");
            Console.WriteLine($"|\tAvarage sales per depertment:\t|");
            Console.WriteLine($"|===============================================");
            int count = 1;
            foreach (double salesTotal in avarageSalesD)
            {
                Console.WriteLine($"|\tDepertment {count}: {salesTotal:C}\t|");
                Console.WriteLine($"|-----------------------------------------------");
                count++;
            }

            // display the average sales for each month
            double[] avarageSalesM = department.calculateAvgSalesPerMonth();
            Console.WriteLine($"|-----------------------------------------------");
            Console.WriteLine($"|\tAvarage sales per month:\t|");
            Console.WriteLine($"|===============================================");

            count = 1;
            foreach (double salesTotal in avarageSalesM)
            {
                Console.WriteLine($"|\tMonth {count}: {salesTotal:C}\t|");
                Console.WriteLine($"|-----------------------------------------------");
                count++;
            }

            // ask user to enter a department number
            Console.WriteLine($"Enter department to get highest monthly sales (1-3):");
            int userInputD = int.Parse(Console.ReadLine());

            // output the month with the highest sales for that department
            Console.WriteLine($"Highest Department Sales: {department.determineHighestMonthlySales(userInputD)}");

            // ask user to enter a month number
            Console.WriteLine($"Enter month to get highest department in sales (1-4):");
            int userInputM = int.Parse(Console.ReadLine());

            // output the department with the highest sales for that month
            Console.WriteLine($"Highest Department Sales: {department.determineHighestDepartSales(userInputM)}");

            _ = Console.ReadKey();
        }
    }
}
