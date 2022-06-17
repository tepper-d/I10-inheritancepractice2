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
* 1-E/5. Complete the derived Staff Class
*          i. staffID       private string
*         ii. use a getter and setter
*        iii. define 2 constructors
*         iv. StaffWrite    method
* ********************************* Tepper, 16JUN2022 */

namespace ConsoleApp1
{
    public class Staff : IPerson
    {

        //i. private string
        private string staffID;

        //iii. constructor 1
        public Staff() { }

        //iii. constructor with 1 parameter
        public Staff(string staffID)
        {
            this.staffID = staffID;
        }

        //ii. Staff getter & setter
        public string FirstName { get; set; } = "Snoop";
        public string LastName { get; set; } = "Dog";
        public string Email { get; set; } = "snoop.dog@staff.email.me";
        public string StaffID { get; set; } = "STF234567";

        //iv. StaffWrite() method
        public void PersonWrite()
        {
            Console.WriteLine($"{StaffID} is {FirstName} {LastName} and their email is {Email}.");
        }
    }
}
