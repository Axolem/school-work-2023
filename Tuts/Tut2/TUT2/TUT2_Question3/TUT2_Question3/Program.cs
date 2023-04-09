namespace TUT2_Question3
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			string highestScorerName = "", lowestScorerName = "";
			int highestScore = 0, lowestScore = 100, count = 0;
			int[] marks = new int[10];


			while (count < marks.Length)
			{
				// Prompt user for student name and test mark
				Console.Write($"Enter {count + 1} student's name (or -1 to exit): ");
				string name = Console.ReadLine() ?? "Value required";

				Console.Write("Enter test mark (as integer percentage): ");
				int mark = int.Parse(Console.ReadLine() ?? "Value required");

				// Check if wanted to terminate
				if (mark < 0)
				{
					break;
				}

				//Check if mark doesn't exist
				if (marks.Contains(mark))
				{
					Console.WriteLine("Mark is alread in the array. Try again!");
					continue;
				}
				else
				{
					marks[count] = mark;
					count++;
				}

				// Update highest and lowest scores if necessary
				if (mark > highestScore)
				{
					highestScore = mark;
					highestScorerName = name;
				}
				if (mark < lowestScore)
				{
					lowestScore = mark;
					lowestScorerName = name;
				}
			}

			// Display highest and lowest scores and their corresponding names
			Console.WriteLine($"The highest mark was {highestScore}% obtained by {highestScorerName}.");
			Console.WriteLine($"The lowest mark was {lowestScore}% obtained by {lowestScorerName}.");
		}
	}
}