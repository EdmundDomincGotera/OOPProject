using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Person
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string Birthday;
        public string Address;
        public string Contact;


        public Person(string firstName, string lastName, string middleName = " ")
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }
        public string GetFullName()
        {
            FirstName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(FirstName.ToLower());
            MiddleName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(MiddleName.ToLower());
            LastName = System.Threading.Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(LastName.ToLower());
            return FirstName + " " + LastName + ". " + MiddleName;
        }

        public int GetAge()
        {
            return Calculations.CalculateAge(Birthday, true);
        }
    }
}
