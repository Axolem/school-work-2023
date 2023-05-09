using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Question2
{
	public partial class Form1 : Form
	{
		// Declare global variables
		private string studentNo;
		private double assignment, test, exam, final;
		private Student student;
		private readonly StudentRecord studentRecord = new StudentRecord();

		public Form1()
		{
			InitializeComponent();

			// Set displayBox properties
			displayBox.ColumnWidth = 100;
			displayBox.MultiColumn = true;
			displayBox.SelectionMode = SelectionMode.MultiSimple;
		}

		// Calculate final mark
		private void computeBtn_Click(object sender, EventArgs e)
		{
			// Get data from the form
			studentNo = stuNumTxT.Text;
			assignment = double.Parse(assgnTxt.Text);
			test = double.Parse(testTxt.Text);
			exam = double.Parse(examTxt.Text);

			// Calculate final mark
			final = ((assignment / 100 * 0.2) + (test / 100 * 0.3) + (exam / 100 * 0.5)) * 100;

			// Display final mark
			finalTxt.Text = final.ToString();

			// Create a new student object
			student = new Student(studentNo, assignment, test, exam, final);
		}

		// Save student data to a text file
		private void writeBtn_Click(object sender, EventArgs e)
		{
			try
			{
				studentRecord.SaveToFile();
				_ = MessageBox.Show("Saved to a text file.");
			}
			catch (Exception ex)
			{
				_ = MessageBox.Show(ex.Message);
			}
		}

		// Display student data in the displayBox
		private void displayBtn_Click(object sender, EventArgs e)
		{
			// Load student data from the text file
			List<Student> data = studentRecord.LoadFromFile();

			// Clear displayBox
			displayBox.Items.Clear();

			// Display each student's data in a formatted string
			foreach (Student student in data)
			{
				string result = student.FinalMarks > 49 ? "Pass" : "Fail";
				string displayString = $"{student.StudentNumber}\t                      {student.FinalMarks}\t                    {result}";
				_ = displayBox.Items.Add(displayString);
			}
		}


		// Add student to the studentRecord
		private void addBtn_Click(object sender, EventArgs e)
		{
			try
			{
				studentRecord.AddStudent(student);
				_ = MessageBox.Show("Added new student.");
			}
			catch (Exception ex)
			{
				_ = MessageBox.Show(ex.Message);
			}
		}

		// Exit the program
		private void exitBtn_Click(object sender, EventArgs e)
		{
			Environment.Exit(0);
		}

		// Clear the form and studentRecord
		private void clearBtn_Click(object sender, EventArgs e)
		{
			// Clear form controls
			stuNumTxT.Clear();
			assgnTxt.Clear();
			testTxt.Clear();
			examTxt.Clear();
			finalTxt.Clear();

			// Clear studentRecord
			studentRecord.ClearStudents();
		}
	}
}
