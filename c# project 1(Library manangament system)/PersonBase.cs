using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__project_1_Library_manangament_system_
{
    public abstract class PersonBase : Iperson // abstract base class that implements the Iperson interface
    {
        public string PersonID { get; set; } // property to store the person's unique ID
        public string Name { get; set; }    // property to store th person's name

        // consctructor to intialize the person's Id and name 
        public PersonBase(string personID, string name) 
        {
            PersonID = personID;
            Name =name;
        }
        public abstract void DisplayInfo(); // abstract method to display the person's information must be implemented by drived classes
         
    }
}
