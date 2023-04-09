using System;
using System.IO;

namespace DataLayer
{
	public class Database
	{
		private static readonly string connectionString = "Staff.txt";

		public bool AddToDatabase(string data)
		{

			try
			{
				using (StreamWriter writer = new StreamWriter(connectionString, true)
				{
					AutoFlush = true
				})
				{
					//Writting to the file
					writer.WriteLine(data);
					writer.Flush();
					//Close connection to the file
					writer.Close();
				}

				return true;
			}
			catch (Exception)
			{

				return false;
			}
		}

		public string ReadFromDatabase()
		{
			string data;
			using (StreamReader reader = new StreamReader(connectionString))
			{
				// Reading the whole file
				data = reader.ReadToEnd();
			}
			return data;
		}
	}
}
