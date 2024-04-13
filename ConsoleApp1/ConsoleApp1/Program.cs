using System.ComponentModel;
using System.Diagnostics.Metrics;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a list of people
            List<Person> myPeople = new List<Person>();
            while (true)
            {
                Console.WriteLine(" \"ADD\" to add a new user to the list, \"PRINT\" to show the information of all added people, \"PERSON'S NAME\" to show their information, \"EXIT\" to leave");
                string input = Console.ReadLine();
                Console.Write("\n");
                // Exit the program
                if (input.Equals("exit", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                // Add a new person
                } else if (input.Equals("add", StringComparison.OrdinalIgnoreCase))
                {
                    myPeople.Add(getInfo());
                    Console.Write("\n");

                // Print the information of all people
                } else if (input.Equals("print", StringComparison.OrdinalIgnoreCase))
                {
                    for (int counter = 0; counter <myPeople.Count; counter++)
                    {
                        myPeople[counter].printInfo();
                    }
                }
                else
                {
                    // Try to find the person by name
                    Person foundPerson = myPeople.Find(person => person.name.Equals(input, StringComparison.OrdinalIgnoreCase));

                    // If the person is found, print their information
                    if (foundPerson != null)
                    {
                        foundPerson.printInfo();
                    }
                    else
                    {
                        Console.WriteLine("Invalid input");
                        Console.Write("\n");
                    }
                }
            }

            // Get the information of a person
            Person getInfo()
            {
                Console.WriteLine("Enter name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter height: ");
                float height = float.Parse(Console.ReadLine());
                Console.WriteLine("Enter weight: ");
                float weight = float.Parse(Console.ReadLine());
                return new Person(name, height, weight);
            }
        }
    }
}
