using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbookmain
{
    public class uc4
    {
        public  void RemovePerson()
        {
            List<uc1> people = FindPeopleByFirstName();

            Console.Clear();

            if (people.Count == 0)
            {
                Console.WriteLine("That person could not be found. Press any key to continue");
                Console.ReadKey();
                return;
            }

            if (people.Count == 1)
            {
                RemovePersonFromList(people.Single());
                return;
            }

            Console.WriteLine("Enter the number of the person you want to remove");
            for (int i = 0; i < people.Count; i++)
            {
                Console.WriteLine(i);
                PrintPerson(people.ElementAt(i));
            }
            int removePersonNumber = Convert.ToInt32(Console.ReadLine());
            if (removePersonNumber > people.Count - 1 || removePersonNumber < 0)
            {
                Console.WriteLine("That number is invalid. Press any key to continue.");
                Console.ReadKey();
                return;
            }
            RemovePersonFromList(people.ElementAt(removePersonNumber));
        }
        private static void RemovePersonFromList(uc1 person)
        {
            Console.Clear();
            Console.WriteLine("Are you sure you want to remove this person from your address book? (Y/N)");
            PrintPerson(person);

            if (Console.ReadKey().Key == ConsoleKey.Y)
            {
                program.people.Remove(person);
                Console.Clear();
                Console.WriteLine("Person removed. Press any key to continue.");
                Console.ReadKey();
            }
        }
        private static void PrintPerson(uc1 person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.PhoneNumber);
            Console.WriteLine("Address 1: " + person.Addresses[0]);
            Console.WriteLine("Address 2: " + person.Addresses[1]);
            Console.WriteLine("-------------------------------------------");
        }
        private static List<uc1> FindPeopleByFirstName()
        {
            Console.Clear();
            Console.WriteLine("Enter the first name of the person you would like to find.");
            string firstName = Console.ReadLine();
            return program. people.Where(x => x.FirstName.ToLower() == firstName.ToLower()).ToList();
        }

    }

}

