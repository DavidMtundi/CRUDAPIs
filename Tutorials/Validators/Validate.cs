﻿using System.Text.RegularExpressions;

namespace Tutorials.Validators
{
    public static class Validate
    {
        /// <summary>
        /// this function chekcs whether the name is valid or not
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public static bool CheckIfNameIsValid(string name)
        {
            Regex rx = new Regex(@"\b([A-Za-z0-9]+)\b", RegexOptions.Compiled | RegexOptions.IgnoreCase);
            int value = 0;
            //check if the name provided is a string (regex checks if the name is not a pure special character)
            if (!rx.IsMatch(name) || int.TryParse(name, out value))
            {
                Console.WriteLine("The String Contains Either Special Characters or Numerals please check on it");
                return false;
            }
            if (string.IsNullOrEmpty(name) || string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("The entered name is possibly null or is only a whitespace");
                return false;
            }
            if (name.Length < 2)
            {
                Console.WriteLine("A name should have more than 2 characters");
                return false;
            }
            return true;
        }
        /// <summary>
        /// this is a function that checks if age is valid or not
        /// </summary>
        /// <param name="age"></param>
        /// <returns></returns>
        public static bool CheckIfAgeIsValid(string age)
        {
            int defaultage = 0;
            bool iscorrect = int.TryParse(age, out defaultage);

            if (!iscorrect)
            {
                Console.WriteLine("The Age You've Entered is Invalid it's a string. please check on it");
                return false;
            }
            if ((int.Parse(age) < 1) || (int.Parse(age) >= 200))
            {
                Console.WriteLine("The Age should be greater than 0 and less than 200");
                return false;

            }
            int enteredage = int.Parse(age);
            DateTime date = DateTime.Now;
            try
            {
                date = DateTime.Now.AddYears(-enteredage);
            }
            catch (Exception)
            {
                Console.WriteLine("The age you've entered is invalid");
                return false;
            }
            return iscorrect ? true : false;

        }
        /// <summary>
        /// returns the date after subtraction
        /// </summary>
        /// <param name="years"></param>
        /// <returns></returns>
        public static DateTime getDateAfterSubtraction(int years)
        {
            return DateTime.Now.AddYears(-years);
        }

    }
}
