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
 * 1-B/2. Complete the derived Student Class
 *          i. studentID       private string
 *         ii. use a getter and setter
 *        iii. define 2 constructors
 *         iv. StudentWrite    method
 * ********************************* Tepper, 16JUN2022 */

namespace ConsoleApp1
{
    public class Student : IPerson
    {
        
        //i.private string
        private string studentID;

        //iii. constructor 1
        public Student() { }

        //iii. constructor2 with 1 parameter
        public Student(string studentID)
        {
            this.studentID = studentID;
        }


        //ii. Student getter & setter
        public string FirstName { get; set; } = "Snoop";
        public string LastName { get; set; } = "Dog";
        public string Email { get; set; } = "snoop.dog@student.email.me";
        public string StudentID { get; set; } = "STU987654";

        //iv. StudentWrite() method
        public void PersonWrite()
        {
            Console.WriteLine ($"{StudentID} is {FirstName} {LastName} and their email is {Email}.");
        }
    }
}
