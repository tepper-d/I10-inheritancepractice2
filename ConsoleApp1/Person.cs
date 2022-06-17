using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
/*********************************************************
* CIS 123: Introduction to Object-Oriented Programming
* Module 10: Inheritance Assignment (Individual)
* Dominique Tepper, 16JUN2022
* 
* 1-A Person class properties
*      firstName   string
*      lastName    string
*      email       string    
*      Method
*          a. PersonWrite
* ********************************* Tepper, 16JUN2022 */
    public class Person : IPerson
    {
        public string firstName;
        public string lastName;
        public string email;

        public Person() { }

        public Person(string firstName, string lastName, string email)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
        }

        //Tepper, 16JUN2022
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                if (value.Length > 50)
                {
                    throw new ArgumentException(
                        "First name must not exceed 50 characters", "Input Error");
                }
                firstName = value;
            }
        }

        //Tepper, 16JUN2022
        public string LastName
        {
            get
            {
                return lastName;
            }
            set
            {
                if (value.Length > 60)
                {
                    throw new ArgumentException(
                        "Last name must not exceed 60 characters", "Input Error");
                }
                lastName = value;
            }
        }

        //Tepper, 16JUN2022
        public string Email
        {
            get
            {
                return email;
            }
            set
            {
                if (value.Length > 70)
                {
                    throw new ArgumentException(
                        "Email must not exceed 70 characters", "Input Error");
                }
                email = value;
            }
        }

        //PersonWrite() method
        public void PersonWrite()
        {
            Console.WriteLine($"{FirstName} {LastName}'s email is {Email}.");
        }

    }
}
