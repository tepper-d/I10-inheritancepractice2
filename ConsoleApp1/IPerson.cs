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
 *      
 * 1-A Person  properties
 *          i. firstName   string
 *         ii. lastName    string
 *        iii. email       string    
 *      Method
 *         iv. PersonWrite
 * ********************************* Tepper, 16JUN2022 */


namespace ConsoleApp1
{
    public interface IPerson
    {       
        // i. first name string
        public string FirstName { get; set; }

        // ii. first name string
        public string LastName { get; set; }

        // iii. first name string
        public string Email { get; set; }


        // iv. first name string
        public void PersonWrite();

    }
}
