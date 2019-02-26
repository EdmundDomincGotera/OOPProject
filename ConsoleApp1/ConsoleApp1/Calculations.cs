using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Calculations
    {
        public static int CalculateAge(string birthDate, bool returnInMonths = false)
        {
            int age;

            DateTime now = DateTime.UtcNow;
            DateTime past = Convert.ToDateTime(birthDate);


            if (now.Year > past.Year)
            {
                age = (now.Year - past.Year);

                if (returnInMonths)
                {
                    age = age * 12;
                }
                age += (now.Month - past.Month);
                return age;
            }
            else
            {
                age = (past.Year - now.Year);
                if (age == 1)
                {
                    returnInMonths = false;
                }
                if (returnInMonths)
                {
                    age = age * 12;
                }
                age = (now.Month - past.Month);
                return age;
            }
        }

        public static decimal CalculateInterest(decimal principalAmount, decimal monthlyRate, int items)
        {
            principalAmount = principalAmount * items;
            decimal interest = principalAmount * (monthlyRate / 100);
            return interest;
        }
        public static decimal CalculateAccruedAmount(decimal principalAmount, decimal monthlyRate, int items, string date)
        {
            return (principalAmount * items) + CalculateInterest(principalAmount, monthlyRate, items) * CalculateAge(date, true);
        }
    }
}
