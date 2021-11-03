﻿using System;
using System.Text.RegularExpressions;

namespace RegexWithLambdaExpression
{
    public class RegularExpressionValidation
    {
        const string FIRSTNAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        const string LASTNAME_PATTERN = "^[A-Z]{1}[a-z]{2,}$";
        const string EMAIL_PATTEREN = "^[a-zA-Z0-9]+([.#_$+-][a-zA-Z0-9]+)*[@][a-zA-Z0-9]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2})?$";
        const string PHONE_NUMBER_PATTEREN = "^[0-9]{2}[ ][0-9]{10}$";
        const string PASSWORD_PATTEREN = "(?=.[A-Z])(?=.[0-9])(?=.[!@#$%^&()+=-])[a-zA-Z0-9!@#$%^&*()+=-]{8,}$";


        ////UC1 ==> method to check firstname with exception handling
        public string FirstnameCheck(string firstName)
        {
            try
            {
                if (string.IsNullOrEmpty(firstName))
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.EMPTY_NAME, "FirstName Could not be Empty or null");
                if (Regex.IsMatch(firstName, FIRSTNAME_PATTERN))
                    return "First Name Validated";
                else
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.INVALID_NAME, "First name starts with Cap and has minimum 3 characters");
            }
            catch (RegularExpressionCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        ////UC2 ==> method to check lastname with exception handling
        public string LastNameCheck(string lastName)
        {
            try
            {
                if (string.IsNullOrEmpty(lastName))
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.EMPTY_NAME, "LastName Could not be Empty or null");
                if (Regex.IsMatch(lastName, LASTNAME_PATTERN))
                    Console.WriteLine("Last Name Validated");
                else
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.INVALID_NAME, "Last name starts with Cap and has minimum 3 characters ");
            }
            catch (RegularExpressionCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        ////UC3 ==> method to check email id with exception handling
        public string EmailCheck(string email)
        {
            try
            {
                if (string.IsNullOrEmpty(email))
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.EMPTY_EMAIL, "Email Could not be Empty or null");
                if (Regex.IsMatch(email, EMAIL_PATTEREN))
                    return "email is Validated";
                else
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.INVALID_EMAIL, "E.g. abc.xyz@bl.co.in - Email has 3 mandatory parts (abc, bl & co) and 2 optional(xyz & in) with precise @ and.positions");
            }
            catch (RegularExpressionCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        ////UC4 ==> method to check phonenumber with exception handling
        public string PHNoCheck(string phno)
        {
            try
            {
                if (string.IsNullOrEmpty(phno))
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.EMPTY_PHONE_NO, "Phone Number Could not be Empty or null");
                if (Regex.IsMatch(phno, PHONE_NUMBER_PATTEREN))
                    return "phno is Validated";
                else
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.INVALID_PHONE_NO, "Phone Number Should Have 10 digits and First digits Must starts from [6..9] and [+91 ] is for optional Mobile Format - E.g. 91 6919819801 - Country code follow by space and 10 digit number");
            }
            catch (RegularExpressionCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }

        ////UC5 ==> method to check password with exception handling
        public string PasswordCheck(string password)
        {
            try
            {
                if (string.IsNullOrEmpty(password))
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.EMPTY_PASSWORD, "Password Could not be Empty or null");
                if (Regex.IsMatch(password, PASSWORD_PATTEREN))
                    Console.WriteLine("password is Validated");
                else
                    throw new RegularExpressionCustomException(RegularExpressionCustomException.InvalidUserdetails.INVALID_PASSWORD, "Password Have minimum 8 Characters");
            }
            catch (RegularExpressionCustomException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return null;
        }


        //Lambda Expression for validation check
        public string LambdaExpressionFirstnameCheck(string firstName) => Regex.IsMatch(firstName, FIRSTNAME_PATTERN) ? "firstName is Validated" : "firstName is not Validated";
        public string LambdaExpressionLastnameCheck(string lastName) => Regex.IsMatch(lastName, LASTNAME_PATTERN) ? "lastName is Validated" : "lastName is not Validated";
        public string LambdaExpressionEmailCheck(string email) => Regex.IsMatch(email, EMAIL_PATTEREN) ? "email is Validated" : "email is not Validated";
        public string LambdaExpressionPhoneNumberCheck(string phno) => Regex.IsMatch(phno, PHONE_NUMBER_PATTEREN) ? "phno is Validated" : "phno is not Validated";
        public string LambdaExpressionpasswordCheck(string password) => Regex.IsMatch(password, PASSWORD_PATTEREN) ? "password is Validated" : "password is not Validated";
    }
}