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
    public class Admin : IPerson
    {

        //private string
        private string adminID;

        //constructor 1
        public Admin() { }

        //constructor with 1 parameter
        public Admin(string staffID)
        {
            this.adminID = staffID;
        }


        //class getter & setter
        public string FirstName { get; set; } = "Snoop";
        public string LastName { get; set; } = "Dog";
        public string Email { get; set; } = "snoop.dog@admin.email.me";
        public string AdminID { get; set; } = "ADD234567";

        //AdminWrite() method
        public void PersonWrite()
        {
            Console.WriteLine($"{AdminID} is {FirstName} {LastName} and their email is {Email}.");
        }
    }
}
