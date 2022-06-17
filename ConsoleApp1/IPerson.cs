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
    public interface IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public void PersonWrite();

    }
}
