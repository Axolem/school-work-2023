using System.Collections.Generic;
using System.IO;

namespace Question2
{
	internal class StudentRecord
	{
		// Use auto-implemented property for filePath
		public string FilePath { get; set; } = "exam.txt";

		// Use generic list interface instead of concrete class for students
		private readonly List<Student> students = new List<Student>();

		public void AddStudent(Student student)
		{
			students.Add(student);
		}

		public void ClearStudents()
		{
			students.Clear();
		}

		public void SaveToFile()
		{
			// Use 'using' statement to ensure proper disposal of StreamWriter
			using (StreamWriter writer = new StreamWriter(FilePath, true))
			{
				// Use string interpolation instead of concatenation
				foreach (Student student in students)
				{
					// Use invariant culture to ensure consistent string representation of doubles
					string line = $"{student.StudentNumber};{student.AssignmentMarks.ToString(System.Globalization.CultureInfo.InvariantCulture)};{student.TestMarks.ToString(System.Globalization.CultureInfo.InvariantCulture)};{student.ExamMark.ToString(System.Globalization.CultureInfo.InvariantCulture)};{student.FinalMarks.ToString(System.Globalization.CultureInfo.InvariantCulture)}";
					writer.WriteLine(line);
				}
			}
		}

		public List<Student> LoadFromFile()
		{
			// Use 'using' statement to ensure proper disposal of StreamReader
			using (StreamReader reader = new StreamReader(FilePath))
			{
				// Use generic list constructor to clear students
				List<Student> loadedStudents = new List<Student>();

				string line;
				while ((line = reader.ReadLine()) != null)
				{
					//Split string by ";" to array
					string[] parts = line.Split(';');

					//Take array items and assign to vars
					string studentNo = parts[0];
					double assignmentMarks = double.Parse(parts[1], System.Globalization.CultureInfo.InvariantCulture);
					double testMarks = double.Parse(parts[2], System.Globalization.CultureInfo.InvariantCulture);
					double exam = double.Parse(parts[3], System.Globalization.CultureInfo.InvariantCulture);
					double final = double.Parse(parts[4], System.Globalization.CultureInfo.InvariantCulture);

					loadedStudents.Add(new Student(studentNo, exam, assignmentMarks, testMarks, final));
				}
				// Assign loaded students to students field
				students.Clear();
				students.AddRange(loadedStudents);
				return students;
			}
		}
	}
}
