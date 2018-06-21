using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarQuotesMVC.Models
{
    public class AgeFromBirthdayCalculator
    {
        public int getAgeFromBirthday(DateTime dob)
        {
            var birthday = dob;
            var today = DateTime.Today;
            int datediffyear = today.Year - birthday.Year;
            var birthdayMonth = birthday.Month;
            var birthdayDay = birthday.Day;
            var birthdayInCurrentYear = new DateTime(today.Year, birthdayMonth, birthdayDay, 0, 0, 0);
            int age = datediffyear;
            if (birthdayInCurrentYear > today)
            {
                age = datediffyear - 1;
            }
            return age;

        }
    }
}