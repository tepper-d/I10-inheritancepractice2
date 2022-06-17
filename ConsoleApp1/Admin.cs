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
* 1-D/4. Complete the derived Admin Class
*          i. AdminID       private string
*         ii. use a getter and setter
*        iii. define 2 constructors
*         iv. AdminWrite    method
* ********************************* Tepper, 16JUN2022 */

namespace ConsoleApp1
{
    public class Admin : IPerson
    {

        //i. private string
        private string adminID;

        //iii. constructor 1
        public Admin() { }

        //iii. constructor with 1 parameter
        public Admin(string staffID)
        {
            this.adminID = staffID;
        }


        //Admin getter & setter
        //Tepper, 16JUN2022
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
