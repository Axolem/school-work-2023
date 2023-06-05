using DataLayer;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class BusinessLayerClass
    {
        //Axole Maranjana 220023913

        private string email;
        private string phone;
        private bool password;

        //Create new data layer object
        private readonly DataLayerClass dataLayer = new DataLayerClass();

        public string generateEmail(string name, string surname)
        {
            //Generate email and set it
            email = $"{name.Substring(0, 1)}{surname}@coders.cO.za".ToLower();

            //Return the email
            return email;
        }
        public string formatNumber(string phone)
        {
            this.phone = "";
            for (int i = 0; i < phone.Length; i++)
            {
                if (i == 0) { this.phone += "("; }
                if (i == 3) { this.phone += ") "; }
                if (i == 6) { this.phone += "-"; }

                this.phone += phone[i];
            }

            //this.phone = $"({phone.Substring(0, 3)}) {phone.Substring(3,3)}-{phone.Substring(6)}";

            return this.phone;
        }

        //Checks the strength of the password
        public bool validatePassword(string password)
        {
            //Init the values that must be in the password
            string digits_all = "0123456789";
            string letters_lower = "abcdegfhijlkmnopqrstuvwxyz";
            string letters_upper = letters_lower.ToUpper();

            //Counters to keep track of the requirements
            int digits = 0;
            int lowercase = 0;
            int uppercase = 0;

            //Loop the password char by char
            foreach (char letter in password)
            {
                //Find index of the char and increament it's counter if true
                if (letters_lower.IndexOf(letter) != -1) { lowercase++; }
                if (letters_upper.IndexOf(letter) != -1) { uppercase++; }
                if (digits_all.IndexOf(letter) != -1) { digits++; }
            }

            //Check if all counters are meeting the requirements
            this.password = lowercase >= 2 && uppercase >= 2 && digits >= 2;

            return this.password;
        }

        //Format data and send it to file
        public void SaveDataToFile()
        {
            string data = $"{email},{phone},{password}";
            dataLayer.writeToFile(data);
        }

        //Fetch and format data
        public string[] ReadDataFromFile()
        {
            List<string> rawData = dataLayer.readFromFile();
            List<string> cleanData = new List<string>();

            foreach (string rawLine in rawData)
            {
                cleanData.Add(rawLine.Replace(",", " "));
            }

            return cleanData.ToArray();
        }

    }
}
