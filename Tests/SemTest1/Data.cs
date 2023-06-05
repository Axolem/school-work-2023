namespace SemTest1
{
	internal class Data
	{
		//Declare private variables
		int number;
		string name, surname, email, gender, ip;

		//Variables to access variables and update them
		public string Name { get { return name; } set { name = value; } }
		public string Surname { get { return surname; } set { surname = value; } }
		public string Email { get { return email; } set { email = value; } }
		public string Gender { get { return gender; } set { gender = value; } }
		public string Ip { get { return ip; } set { ip = value; } }
		public int Number { get { return number; } set { number = value; } }

		//Constructor
		public Data() { }
	}
}
