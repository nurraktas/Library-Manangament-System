using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__project_1_Library_manangament_system_
{    // librarian class represents a librarian in the libabry system 
    public class Librarian : PersonBase
    {
        public decimal Salary { get; set; } 
        public  string Speciality {get; set; }
         
        // constructor to initialize a librarian with ID, name , salary and speciality
        public Librarian(string personID, string name,decimal salary , string speciality)
            :base(personID, name)
        { 
            Salary = salary;
            Speciality = speciality;    
        }

        // override method to display librarian information
        public override void DisplayInfo()
        {
            Console.WriteLine($"Librarian: {Name}, ID: {PersonID}, Salary: {Salary}, Speciality: {Speciality}");
        }
    }
}
