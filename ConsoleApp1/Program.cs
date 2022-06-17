// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

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

using ConsoleApp1;

//student
var student1 = new Student()
{
    FirstName = "Schoen",
    LastName = "Pueh",
    Email = "schoen.pueh@email.me",
    StudentID = "STU876543"
};
student1.PersonWrite();


Student student2 = new Student();
student2.FirstName = "Soon";
student2.LastName = "Pye";
student2.Email = "soon.pye@email.me";
student2.StudentID = "STU765432";
student2.PersonWrite();


//faculty
var faculty1 = new Faculty()
{
    FirstName = "Yspoie",
    LastName = "Nguyen",
    Email = "yspoie.nguyen@faculty.me",
    FacultyID = "FAC345678"
};
faculty1.PersonWrite();


Faculty faculty2 = new Faculty();
faculty2.FirstName = "Soon";
faculty2.LastName = "Pye";
faculty2.Email = "soon.pye@email.me";
faculty2.FacultyID = "STU765432";
faculty2.PersonWrite();


//Admin
var admin1 = new Admin()
{
    FirstName = "Blu",
    LastName = "Hydrangea",
    Email = "blu.hydrangea@admin.me",
    AdminID = "ADM135792"
};
admin1.PersonWrite();


Admin admin2 = new Admin();
admin2.FirstName = "Roxxy";
admin2.LastName = "Andrews";
admin2.Email = "roxxy.andrews@admin.me";
admin2.AdminID = "ADM246813";
admin2.PersonWrite();


//Staff
