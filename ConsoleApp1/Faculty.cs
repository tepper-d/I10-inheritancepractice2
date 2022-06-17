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
 * 1-C/3. Complete the derived Staff Class
 *          i. facultyID       private string
 *         ii. use a getter and setter
 *        iii. define 2 constructors
 *         iv. FacultyWrite    method
 * ********************************* Tepper, 16JUN2022 */

namespace ConsoleApp1
{
    public class Faculty : IPerson
    {
        
        //i. private string
        private string facultyID;

        //iii. constructor 1
        public Faculty() { }

        //iii. constructor with 1 parameter
        public Faculty(string facultyID)
        {
            this.facultyID = facultyID;
        }

        //ii. Faculty getter & setter
        //Tepper, 16JUN2022
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
