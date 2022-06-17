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
    public class Student : IPerson
    {
        
        //private string
        private string studentID;

        //constructor 1
        public Student() { }

        //constructor2 with 1 parameter
        public Student(string studentID)
        {
            this.studentID = studentID;
        }


        //class getter & setter
        public string FirstName { get; set; } = "Snoop";
        public string LastName { get; set; } = "Dog";
        public string Email { get; set; } = "snoop.dog@student.email.me";
        public string StudentID { get; set; } = "STU987654";

        //StudentWrite() method
        public void PersonWrite()
        {
            Console.WriteLine ($"{StudentID} is {FirstName} {LastName} and their email is {Email}.");
        }
    }
}
