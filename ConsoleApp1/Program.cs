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
Console.WriteLine("These are Summer interns:");

var student1 = new Student()
{
    FirstName = "Schoen",
    LastName = "Pueh",
    Email = "schoen.pueh@student.email.me",
    StudentID = "STU876543"
};
student1.PersonWrite();


Student student2 = new Student();
student2.FirstName = "Soon";
student2.LastName = "Pye";
student2.Email = "soon.pye@student.email.me";
student2.StudentID = "STU765432";
student2.PersonWrite();


//faculty --Tepper, 16JUN2022
Console.WriteLine("Retiring faculty members: ");

var faculty1 = new Faculty()
{
    FirstName = "Yspoie",
    LastName = "Nguyen",
    Email = "yspoie.nguyen@faculty.email.me",
    FacultyID = "FAC345678"
};
faculty1.PersonWrite();


Faculty faculty2 = new Faculty();
faculty2.FirstName = "Soon";
faculty2.LastName = "Pye";
faculty2.Email = "soon.pye@faculty.email.me";
faculty2.FacultyID = "FAC842367";
faculty2.PersonWrite();


//Admin --Tepper, 16JUN2022
Console.WriteLine("These are temp Admin:");

var admin1 = new Admin()
{
    FirstName = "Blu",
    LastName = "Hydrangea",
    Email = "blu.hydrangea@admin.email.me",
    AdminID = "ADM135792"
};
admin1.PersonWrite();


Admin admin2 = new Admin();
admin2.FirstName = "Roxxy";
admin2.LastName = "Andrews";
admin2.Email = "roxxy.andrews@admin.email.me";
admin2.AdminID = "ADM246813";
admin2.PersonWrite();


//Staff --Tepper, 16JUN2022
Console.WriteLine("These are new hourly staff:");

var staff1 = new Staff()
{
    FirstName = "Alyssa",
    LastName = "Edwards",
    Email = "alyssa.edwards@staff.email.me",
    StaffID = "STF741369"
};
staff1.PersonWrite();


Staff staff2 = new Staff();
staff2.FirstName = "Vanjie";
staff2.LastName = "Mateo";
staff2.Email = "vanjie.mateo@staff.email.me";
staff2.StaffID = "STF852963";
staff2.PersonWrite();

Console.WriteLine("-- End of Report --");