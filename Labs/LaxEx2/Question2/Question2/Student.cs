namespace Question2
{
	// Define a Student class
	internal class Student
	{
		// Properties of the Student class
		public string StudentNumber;
		public double ExamMark;
		public double AssignmentMarks;
		public double TestMarks;
		public double FinalMarks;

		// Constructor of the Student class
		public Student(string studentNumber, double exam, double assignmentMarks, double testMarks, double finalMarks)
		{
			// Initialize the properties with the passed values
			StudentNumber = studentNumber;
			ExamMark = exam;
			AssignmentMarks = assignmentMarks;
			TestMarks = testMarks;
			FinalMarks = finalMarks;
		}
	}
}
