using DataLayer;
using System.Collections.Generic;

namespace BusinessLayer
{
    public class BusinessLayerClass
    {
        private readonly DataLayerClass dataLayer = new DataLayerClass();

        private string username;
        public int Age { get; private set; } = 0;
        public string Username { set => username = value; }

        public void CalculateAge(string id)
        {
            string year = id.Substring(0, 2);

            if (int.Parse(year) > 21)
            {
                year = "19" + year;
            }
            else
            {
                year = "20" + year;
            }

            int age = 2023 - int.Parse(year);

            Age = age;
        }

        public void Save()
        {
            string data = $"{username},{Age}";

            dataLayer.WriteToFile(data);
        }

        public string[] Read()
        {
            List<string> rawData = dataLayer.ReadFromFile();
            List<string> cleanData = new List<string>();

            foreach (string rawLine in rawData)
            {
                string cleanLine = rawLine.Replace(',', ' ');

                cleanData.Add(cleanLine);
            }

            return cleanData.ToArray();
        }

    }
}
