using System;
using System.IO;

namespace Question2
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// Specify the path of the data file
			string projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
			string filePath = projectDirectory + "data.txt";

			//Take the txt in the debug folder
			if (filePath.Length < 10)
			{
				filePath = "data.txt";
			}

			// Loop until the user exits the program
			while (true)
			{
				// Display welcome screen
				Console.WriteLine("*****************************************************************");
				Console.WriteLine("*                     BIG DATA APPLICATION                      *");
				Console.WriteLine("*****************************************************************");
				Console.WriteLine(" ");

				// Display options for the user
				Console.WriteLine("1: Display all data from the dataset");
				Console.WriteLine("2: Display all data based on the given year (2001 - 2021)");
				Console.WriteLine("3: Display all data based on the level (1 - 4)");
				Console.WriteLine("0: Exit...");
				Console.WriteLine(" ");

				// Prompt the user to enter an option
				Console.Write("Enter option: ");
				int option = int.Parse(Console.ReadLine());

				if (option == 0) // Exit the program
				{
					break;
				}
				else if (option == 1) // Display all data
				{
					ReadAllData(filePath);
				}
				else if (option == 2) // Display data based on the given year
				{
					Console.Write("Enter year: ");
					int year = int.Parse(Console.ReadLine());
					DisplayDataByYear(filePath, year);
				}
				else if (option == 3) // Display data based on the given category
				{
					Console.Write("Enter level: ");
					int level = int.Parse(Console.ReadLine());
					DisplayDataByLevel(filePath, level);
				}
				else // Invalid option
				{
					Console.WriteLine("Invalid option!");
					continue;
				}
			}

			// Display farewell message
			Console.WriteLine("Thank you for using this program.");
			_ = Console.ReadKey();
		}

		// Reads and displays all data from the file
		private static void ReadAllData(string filePath)
		{
			using (StreamReader sr = new StreamReader(filePath))
			{
				Console.WriteLine(sr.ReadToEnd());
			}
		}

		// Displays data from the file that match the given year
		private static void DisplayDataByYear(string filePath, int yearFilter)
		{
			using (StreamReader sr = new StreamReader(filePath))
			{
				while (!sr.EndOfStream)
				{
					string line = sr.ReadLine();
					string[] fields = line.Split(',');

					// Extract the year from the data and convert it to an integer
					int year = int.Parse(fields[0]);

					if (year == yearFilter) // Display the data if the year matches the filter
					{
						Console.WriteLine(line);
					}
				}
			};
		}

		// Displays data from the file that match the given category
		private static void DisplayDataByLevel(string filePath, int level)
		{
			using (StreamReader sr = new StreamReader(filePath))
			{
				while (!sr.EndOfStream)
				{
					string line = sr.ReadLine();
					string[] fields = line.Split(',');

					// Extract the level from the data and split by space to get the value
					int dataLevel = int.Parse(fields[1].Split(' ')[1]);

					if (dataLevel == level) // Display the data if the category matches the filter
					{
						Console.WriteLine(line);
					}
				}
			}
		}
	}
}
