using BusinessLayer;
using System;
using System.Windows.Forms;

namespace TUT3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		// Initialising global vars
		private string name, surname, email, idNumber;
		private int age;
		private readonly BusinessLogic business = new BusinessLogic();

		private void BTNexit_Click(object sender, EventArgs e)
		{
			// Terminate the program
			Environment.Exit(0);
		}

		private void BTNclear_Click(object sender, EventArgs e)
		{
			// Clear the app data from the form and reset the variables
			ClearFields();
		}

		private void BTNread_Click(object sender, EventArgs e)
		{
			// Get data from the DB via busib=ness layer
			string[] data = business.FetchFromDatase();

			//Looping through the data
			foreach (string row in data)
			{
				// Display the data
				_ = LSTdisplay.Items.Add(row);
			}
		}

		private void BTNsave_Click(object sender, EventArgs e)
		{
			// Save to the DB via the business layer
			bool saveSuccess = business.SendToDatabase(name, surname, email, age);

			if (saveSuccess)
			{
				// Display success
				_ = MessageBox.Show("Saved successfully");
				// Reset the form
				ClearFields();
			}
			else
			{
				// Display error
				_ = MessageBox.Show("Failed to save try again!");
			}
		}

		private void BTNcreate_Click(object sender, EventArgs e)
		{
			// Get values from the form
			name = TXTname.Text;
			surname = TXTsurname.Text;
			idNumber = TXTidNumber.Text;

			//Generate age & email using business layer
			age = business.GetAge(idNumber);
			email = business.CreateEmail(name, surname);

			//Display generated age z& email back on the form
			LBLage.Text = age.ToString();
			LBLemail.Text = email.ToString();
		}

		private void ClearFields()
		{
			//Reset the labels
			LBLage.Text = string.Empty;
			LBLemail.Text = string.Empty;

			// reset the fields
			TXTidNumber.Clear();
			TXTname.Clear();
			TXTsurname.Clear();

			//Reset the vars
			name = string.Empty;
			surname = string.Empty;
			email = string.Empty;
			idNumber = string.Empty;
			age = 0;

			//LSTdisplay.Items.Clear(); //Not sure if required
		}
	}
}
