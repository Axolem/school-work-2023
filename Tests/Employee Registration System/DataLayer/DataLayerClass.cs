using System.Collections.Generic;
using System.IO;

namespace DataLayer
{
    public class DataLayerClass
    {
        //Axole Maranjana 220023913

        private readonly string file_path = "Employee.txt";

        public void writeToFile(string data)
        {
            StreamWriter sw = new StreamWriter(file_path, true);

            sw.WriteLine(data);
            sw.Close();
        }

        public List<string> readFromFile()
        {
            List<string> data = new List<string>();

            StreamReader sr = new StreamReader(file_path);

            while (!sr.EndOfStream)
            {
                data.Add(sr.ReadLine());
            }

            sr.Close();

            return data;
        }
    }
}
