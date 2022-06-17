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
 *      c/3. Faculty      derived
 *      d/4. Admin        derived
 *      e/5. Staff        derived
 * ******************************************************/

namespace ConsoleApp1
{
    public class Staff : IPerson
    {

        //private string
        private string staffID;

        //constructor 1
        public Staff() { }

        //constructor with 1 parameter
        public Staff(string staffID)
        {
            this.staffID = staffID;
        }


        //class getter & setter
        public string FirstName { get; set; } = "Snoop";
        public string LastName { get; set; } = "Dog";
        public string Email { get; set; } = "snoop.dog@staff.email.me";
        public string StaffID { get; set; } = "STF234567";

        //StaffWrite() method
        public void PersonWrite()
        {
            Console.WriteLine($"{StaffID} is {FirstName} {LastName} and their email is {Email}.");
        }
    }
}
