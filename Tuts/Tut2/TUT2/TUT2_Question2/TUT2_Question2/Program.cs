namespace TUT2_Question2
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// Prompt user for department code and annual salary
			Console.Write("Enter department code (A, B or other): ");
			string departmentCode = Console.ReadLine() ?? "Value required";
			Console.Write("Enter annual salary: ");
			double annualSalary = double.Parse(Console.ReadLine() ?? "Value required");

			// Initialize percentage increase and department name variables
			double percentageIncrease;
			string departmentName;

			//Make the user input uppercase for allowing both cases from user
			departmentCode = departmentCode.ToLower();

			// Determine percentage increase and department name based on input
			if (departmentCode == "A")
			{
				percentageIncrease = 5.2;
				departmentName = "Department A";
			}
			else
			{
				if (departmentCode == "B")
				{
					percentageIncrease = 4.8;
					departmentName = "Department B";
				}
				else
				{
					percentageIncrease = 4.3;
					departmentName = "Other Department";
				}
			}

			// Calculate increased monthly salary and display result
			double monthlySalary = annualSalary / 12.0;
			double increasedMonthlySalary = monthlySalary * (1.0 + (percentageIncrease / 100.0));
			Console.WriteLine($"Employee in {departmentName} with annual salary of {annualSalary:C} will receive an increased monthly salary of {increasedMonthlySalary:C}.");

		}
	}
}