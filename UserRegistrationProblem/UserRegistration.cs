﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace UserRegistrationProblem
{
    public class UserRegistration
    {
        /// <summary>
        /// takes pattern for first name and last name.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public bool FirstAndLastName(string input)
        {
            try
            {
                if (input.Equals(string.Empty))
                {
                    throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.EMPTY_MESSAGE, "first name and last name can not be empty");
                }
                //pattern for first name and last name
                string firstNamePattern = "[A-Z]{1}[A-Za-z]{2,}";
                return Regex.IsMatch(input, firstNamePattern);

            }
            catch (NullReferenceException)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionType.NULL_MESSAGE, "first name and last name can not be null");
            }

        }
        public bool Email(string input)
        {
            //pattern for mail id.
            string emailPattern = @"^([a-z0-9A-Z])+([._+-]?[a-z0-9A-Z]+)*[@]{1}[a-z0-9A-Z]+[.]{1}[a-zA-Z]{3}([.]{1}[a-z]{2})?$";
            return Regex.IsMatch(input, emailPattern);
        }
        public bool MobileNo(string input)
        {
            //pattern for phone no.
            string mobileNoPattern = @"\d{2}\s{1}[6-9]{1}\d{9}";
            return Regex.IsMatch(input, mobileNoPattern);
        }
        public bool Password(string input)
        {
            string passwordPattern = @"^(?=.*[A-Z])(?=.*[0-9])(?=.*[^0-9a-zA-Z])(?!.*[^0-9a-zA-Z].*[^0-9a-zA-Z]).{8,}$";
            return Regex.IsMatch(input, passwordPattern);
        }
    }
}