using DataLayer;
using System;

namespace BusinessLayer
{
    public class BusinessLogic
    {
        private readonly DataBaseLayer database = new DataBaseLayer();

        public bool SendToDatabase(string name, string surname, string email, int age, string idNumber)
        {
            //Add to the database
            try
            {
                database.AddToDatabase(idNumber, name, surname, email, age);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
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
