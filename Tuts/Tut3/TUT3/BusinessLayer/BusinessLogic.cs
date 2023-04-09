using DataLayer;
using System;

namespace BusinessLayer
{
	public class BusinessLogic
	{
		private readonly Database database = new Database();
		public bool SendToDatabase(string name, string surname, string email, int age)
		{
			//Add to the database
			string data = $"{name} {surname} {email} {age}";
			return database.AddToDatabase(data);
		}

		public string[] FetchFromDatase()
		{
			//getting data from db
			string rawData = database.ReadFromDatabase();
			// Separating the  rows 
			string[] rowsData = rawData.Split('\n');
			return rowsData;
		}

		public int GetAge(string idNumber)
		{
			//Calculating age
			int birthYear = int.Parse(idNumber.Substring(0, 2)); //Get first two values from id no
			int century = birthYear < 22 ? 2000 : 1900;
			int fullYear = century + birthYear;
			return DateTime.Now.Year - fullYear;
		}

		public string CreateEmail(string name, string surname)
		{
			//Generating email and make it lower case
			return $"{name.Substring(0, 1)}{surname}@uj.ac.za".ToLower();
		}
	}
}
