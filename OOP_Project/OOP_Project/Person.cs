using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Project
{
    public class Person
    {
        public string FirstName;
        public string MiddleName;
        public string LastName;
        public string Birthday;
        public string Address;

        public Person(string firstName, string lastName, string middleName = " ")
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }
        public string GetFullName()
        {
            return String.Format("{0} (1}, {2}", FirstName, MiddleName[0], LastName);
        }

        public int GetAge()
        {
            return Calculations.CalculateAge(Birthday, true);
        }

        private string FormatName(string name)
        {
            name = name.ToLower();
            string[] names = name.Split(' ');
            string formattedName = "";
            for (int counter = 0; counter < names.Length; counter++)
                formattedName = formattedName + char.ToUpper(names[counter][0]) + names[counter].Substring(1) + " ";
            return formattedName.Remove(formattedName.Length - 1);
        }
    }
}
