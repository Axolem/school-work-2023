using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SemTest1
{
	internal class DataManager
	{
		//Initialising variables
		string filePath = "MOCK_DATA.csv";
		//array to store objects of Data(record)
		List<Data> data = new List<Data>();


		//Method to read from file using streamreader and split data by ',' store the data in record then store record in allRecords.
		public List<Data> readFromFile()
		{
			using (StreamReader reader = new StreamReader(filePath))
			{
				//Read the file line by line
				while (!reader.EndOfStream)
				{
					//Object to store a line(record)
					Data record = new Data();

					//Read next line
					string line = reader.ReadLine();

					//Slpit the line by ,
					string[] strings = line.Split(new char[] { ',' });

					//Update the objects values
					record.Number = int.Parse(strings[0]);
					record.Name = strings[1];
					record.Surname = strings[2];
					record.Email = strings[3];
					record.Gender = strings[4];
					record.Ip = strings[5];

					//Add to array
					data.Add(record);
				}

				//Close the reader
				reader.Close();
				Console.WriteLine(data.Count);
			}

			return data;
		}

		//Get the datas that have the donain
		public List<Data> determineDomain(string domain)
		{
			List<Data> domainData = new List<Data>();
			foreach (Data record in data)
			{
				string[] emailData = record.Email.Split(new char[] { '.' });
				if (emailData.LastOrDefault() == domain)
				{
					domainData.Add(record);
				}
			}
			return domainData;
		}

		//number of records for that given domain name
		public int getCounter(string domain)
		{
			//Int counter
			int counter = 0;

			foreach (Data record in data)
			{
				//If it is true
				if (record.Email.Contains(domain))
				{
					//Increament counter
					counter++;
				}
			}
			return counter;
		}

		public Data getRecord(int number)
		{
			Data dataInNumber = new Data();
			foreach (Data record in data)
			{
				if (record.Number == number)
				{
					dataInNumber = record;
				}
			}
			return dataInNumber;
		}

		//Constructor
		public DataManager() { }

	}
}
