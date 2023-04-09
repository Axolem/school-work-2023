namespace TUT2_Question5
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			//Ask user input
			Console.Write("Enter a number: ");
			int number = int.Parse(Console.ReadLine() ?? "Value required");

			//Calling the methods
			displayThreeTimesTheNumber(number);
			displayNumberPlusTen(number);
			displayNumberSquared(number);

			_ = Console.ReadKey();
		}

		//Method to 3x the number
		private static void displayThreeTimesTheNumber(int number)
		{
			Console.WriteLine($"Three times {number} is {number * 3}");
		}

		//Method to add 10 to the number
		private static void displayNumberPlusTen(int number)
		{
			Console.WriteLine($"{number} plus ten is {number + 10}");
		}

		//Method to calculate the square of the number 
		private static void displayNumberSquared(int number)
		{
			Console.WriteLine($"{number} squared is {number * number}");
		}
	}
}