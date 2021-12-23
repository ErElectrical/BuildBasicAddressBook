using System;
using System.Collections.Generic;
using System.Linq;
namespace addressbook
{
    public class program
    {
        public static List<person> people = new List<person>();
        // it is our address book where our data is being stored
        static void Main(string[] args)
        {
            string command = " ";
            while (command != "exit")
            {
                Console.Clear();
                Console.WriteLine("enter your command ");
                command = Console.ReadLine().ToLower();
                switch(command)
                {
                    case "add":
                        {

                        }
                }
            }
        }
    }
}
