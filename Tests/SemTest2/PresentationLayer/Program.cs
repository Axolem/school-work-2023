using BusinessLayer;
using System;

namespace PresentationLayer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            BusinessLayerClass businessLayer = new BusinessLayerClass();

            while (true)
            {
                DoPrompts();

                int option = int.Parse(Console.ReadLine() ?? "Invalid value entered");
                AddSpaces(2);
                switch (option)
                {
                    case 1:
                        Console.Write("Enter name: ");
                        businessLayer.Username = Console.ReadLine();
                        Console.Write("Enter id number: ");
                        string id = Console.ReadLine();

                        businessLayer.CalculateAge(id);

                        int age = businessLayer.Age;

                        Console.WriteLine($"You are {age} years old.");
                        break;

                    case 2:
                        Console.WriteLine("Saving to file...");
                        businessLayer.Save();
                        Console.WriteLine("Done saving...");
                        break;

                    case 3:
                        string[] data = businessLayer.Read();
                        Console.WriteLine("Current data in file: ");

                        foreach (string record in data)
                        {
                            Console.WriteLine(record);
                        }
                        break;

                    case 0:
                        Environment.Exit(0);
                        break;

                    default:
                        Console.WriteLine("Some error occured, please rerun the app.");
                        break;

                }

                AddSpaces(3);
            }
        }

        private static void AddSpaces(int numberofspaces)
        {
            int count = 0;
            while (count != numberofspaces)
            {
                Console.WriteLine("");
                count++;
            }
        }

        private static void DoPrompts()
        {
            Console.WriteLine("1. Enter name and detertermine age");
            Console.WriteLine("2. Save record to file");
            Console.WriteLine("3. Read the records");
            Console.WriteLine("0. To Exit");
            AddSpaces(1);
            Console.Write("The selected option is: ");            
        }
    }
}
