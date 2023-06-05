using System.Collections.Generic;
using System.IO;

namespace DataLayer
{
    public class DataLayerClass
    {
        private readonly string filePath = "People.txt";

        public void WriteToFile(string data)
        {
            StreamWriter sr = new StreamWriter(filePath, true);
            sr.WriteLine(data);
            sr.Close();
        }

        public List<string> ReadFromFile()
        {
            StreamReader reader = new StreamReader(filePath);
            List<string> data = new List<string>();

            while (!reader.EndOfStream)
            {
                data.Add(reader.ReadLine());
            }

            reader.Close();
            return data;
        }
    }
}
