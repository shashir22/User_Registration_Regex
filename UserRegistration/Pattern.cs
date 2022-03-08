﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace UserRegistration
{
    class Patterns
    {
        public static string Regex_name = "^[A-Z]{1}[a-z]{2,}$";
        public static string Regex_email = "^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2})?$";
        public static string Regex_phone = "^[1-9]{1}[0-9]{1}\\s[1-9]{1}[0-9]{9}$";
        public static string Regex_password = "(?=.*[A-Z])[a-zA-Z0-9]{8,}$";
        public void IsValidFirstName()
        {
            bool flag;
            Console.WriteLine("Enter the first name");

            do
            {
                string firstname = Console.ReadLine();
                flag = (Regex.IsMatch(firstname, Regex_name));
                if (flag == true)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("Invalid, Type again");
            }
            while (flag == false);

        }
        public void IsValidLastName()
        {
            bool flag;
            Console.WriteLine("Enter the last name");
            do
            {
                string lastname = Console.ReadLine();
                flag = (Regex.IsMatch(lastname, Regex_name));
                if (flag == true)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("Invalid, Type again");

            }
            while (!flag);
        }
        public void IsValidEmail()
        {
            bool flag;
            Console.WriteLine("Enter the Email");
            do
            {
                string Email = Console.ReadLine();
                flag = (Regex.IsMatch(Email, Regex_email));
                if (flag == true)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("Invalid, Type again");

            }
            while (!flag);
        }
        public void IsValidPhoneNo()
        {
            bool flag;
            Console.WriteLine("Enter the Phone number");
            do
            {
                string Phone = Console.ReadLine();
                flag = (Regex.IsMatch(Phone, Regex_phone));
                if (flag == true)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("Invalid, Type again");

            }
            while (!flag);
        }
        public void IsValidPasswordRule1()
        {
            bool flag;
            Console.WriteLine("Enter the Password: atleast 1 upper case");
            do
            {
                string Password = Console.ReadLine();
                flag = (Regex.IsMatch(Password, Regex_password));
                if (flag == true)
                    Console.WriteLine("valid");
                else
                    Console.WriteLine("Invalid, Type again");

            }
            while (!flag);
        }

    }
}