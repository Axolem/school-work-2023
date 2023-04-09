namespace TUT2_Question4
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			// Declare the number of students and tests
			int numStudents = 4;
			int numTests = 3;

			// Declare an array to hold each student's final mark and a variable to hold the class average
			double[] studentMarks = new double[numStudents];
			double classAverage = 0;

			// Iterate through each student
			for (int i = 0; i < numStudents; i++)
			{
				// Declare a variable to hold the sum of the student's test scores
				double sum = 0;

				// Iterate through each test for the current student
				sum = addStudentScoresForAllTests(numTests, i, sum);

				// Calculate the average score for the current student by dividing the sum by the number of tests
				double average = sum / numTests;

				// Store the average score in the studentMarks array
				studentMarks[i] = average;

				// Display the student's average score on the console
				Console.WriteLine("Student {0} average score: {1}\n", i + 1, average.ToString("F2"));
			}

			// Iterate through the studentMarks array to calculate the class average
			for (int i = 0; i < numStudents; i++)
			{
				// Add each student's average score to the classAverage variable
				classAverage += studentMarks[i];
			}

			// Divide the classAverage variable by the number of students to get the final class average
			classAverage /= numStudents;

			// Display the class average on the console
			Console.WriteLine("Class average score: {0}", classAverage.ToString("F2"));

			static double addStudentScoresForAllTests(int numTests, int i, double sum)
			{
				for (int j = 0; j < numTests; j++)
				{
					// Prompt the user to enter the score for the current test and add it to the sum
					Console.Write("Enter test score for student {0}, test {1}: ", i + 1, j + 1);
					double testScore = double.Parse(Console.ReadLine() ?? "Value required.");
					sum += testScore;
				}

				return sum;
			}
		}
	}
}