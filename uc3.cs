using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace addressbookmain
{
    public  class uc3
    {
        public  void EditPeopleByFirstName()
        {
            Console.Clear();
            Console.WriteLine("Enter the first name of the person you would like to edit.");
            string firstName = Console.ReadLine();
            Console.WriteLine("do changes");
            uc2 person = new uc2();
            person.AddPerson();
            



        }
    }
}
