using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*********************************************************
 * CIS 123: Introduction to Object-Oriented Programming
 * Module 10: Inheritance Assignment (Individual)
 * Dominique Tepper, 16JUN2022
 * 
 * 1. Complete the base and derived classes:
 *      a.   Person       base
 *      b/2. Student      derived
 *      c/3. Staff      derived
 *      d/4. Staff        derived
 *      e/5. Staff        derived
 * ******************************************************/

namespace ConsoleApp1
{
    public class Faculty : IPerson
    {
        
        //private string
        private string facultyID;

        //constructor 1
        public Faculty() { }

        //constructor with 1 parameter
        public Faculty(string facultyID)
        {
            this.facultyID = facultyID;
        }


        //class getter & setter
        public string FirstName { get; set; } = "Snoop";
        public string LastName { get; set; } = "Dog";
        public string Email { get; set; } = "snoop.dog@faculty.email.me";
        public string FacultyID { get; set; } = "FAC234567";

        //FacultyWrite() method
        public void PersonWrite()
        {
            Console.WriteLine ($"{FacultyID} is {FirstName} {LastName} and their email is {Email}.");
        }
    }
}
