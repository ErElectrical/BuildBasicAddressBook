using System;
namespace addressbookmain
{
    public class program
    {
        public static List<uc1> people = new List<uc1>();

        private static void DisplayHelp()
        {
            Console.Clear();
            Console.WriteLine("Available Commands:");
            Console.WriteLine("add\tAdds a person to address book");
            Console.WriteLine("remove\tRemoves a person from address book");
            Console.WriteLine("list\tLists out all people in the address book");
            Console.WriteLine("search\tSearches for a person in the address book by first name");
            Console.WriteLine("\nPress any key to continue.");
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Console.WriteLine("welcome to address book");
            string command = "";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("Please enter a command: ");
                command = Console.ReadLine().ToLower();

                switch (command)
                {
                    case "add":
                        uc2 per = new uc2();
                        per.AddPerson();
                        break;
                    case "Edit":
                        uc3 perm = new uc3();
                        perm.EditPeopleByFirstName();

                        break;
                    case "remove":
                        uc4 premn = new uc4();
                        premn.RemovePerson();
                        break;
                    default:
                        // Dont display the help text if the user intends to exit the application
                        if (command != "exit")
                        {
                            DisplayHelp();
                        }
                        break;
                }

            }

        }
    }
}
