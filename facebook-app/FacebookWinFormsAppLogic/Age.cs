using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Facebook;
using FacebookWrapper.ObjectModel;

namespace FacebookWinFormsAppLogic
{
    public static class Age
    {
        private enum eDateParts
        {
            Month = 0,
            Day = 1,
            Year = 2
        }

        public static int GetAge(string i_Birthday)
        {
            int currentAge;
            string[] dateParts = i_Birthday.Split('/');
            int yearOfBirth = int.Parse(dateParts[(int)eDateParts.Year]);
            int monthOfBirth = int.Parse(dateParts[(int)eDateParts.Month]);
            int dayOfBirth = int.Parse(dateParts[(int)eDateParts.Day]);

            currentAge = DateTime.Now.Year - yearOfBirth;
            if (DateTime.Now.Month - monthOfBirth < 0)
            {
                currentAge--;
            }
            else if (DateTime.Now.Month - monthOfBirth == 0 && DateTime.Now.Day - dayOfBirth < 0)
            {
                currentAge--;
            }

            return currentAge;
        }
    }
}