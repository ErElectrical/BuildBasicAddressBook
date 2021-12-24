using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbookmain
{
    public class uc2
    {


        public void AddPerson()
        {
            Console.Clear();

            uc1 person = new uc1();

            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Address 1: ");
            string[] addresses = new string[2];
            addresses[0] = Console.ReadLine();

            Console.Write("Enter city : ");
            person.city = Console.ReadLine();

            Console.Write("Enter state: ");
            person.state = Console.ReadLine();

            Console.Write("Enter zipcode : ");
            person.zipcode = Console.ReadLine();

            Console.Write("Enter email : ");
            person.email = Console.ReadLine();







            program.people.Add(person);

        }
    }
}