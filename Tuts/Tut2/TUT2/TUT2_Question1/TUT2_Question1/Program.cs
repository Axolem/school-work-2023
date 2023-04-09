internal class Program
{
	private static void Main(string[] args)
	{
		// Welcome message
		Console.WriteLine("Welcome to UJ Hotel!");
		Console.WriteLine("Please choose a room type:");
		Console.WriteLine("1. Queen bed");
		Console.WriteLine("2. King bed");
		Console.WriteLine("3. King bed and pull-out couch");

		// Get user input
		Console.Write("Enter your choice (1, 2 or 3): ");
		int roomType = int.Parse(Console.ReadLine() ?? "Required value");

		// Initialize price variable
		int price = 0;

		// Determine room price based on input
		if (roomType == 1)
		{
			price = 450;
		}
		else if (roomType == 2)
		{
			price = 690;
		}
		else if (roomType == 3)
		{
			price = 800;
		}
		else
		{
			Console.WriteLine("Invalid room code entered. Please enter 1, 2, or 3.");
		}

		// Display the result
		if (price > 0)
		{
			Console.WriteLine($"You have selected room code {roomType} and the price is {price:C}");
		}
		else
		{
			Console.WriteLine("Price set to 0 due to invalid room code.");
		}
	}
}