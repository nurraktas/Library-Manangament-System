using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__project_1_Library_manangament_system_
{
    // book class represent a book in the library
    public class Book
    {
        // properties to store book information
        public string Title { get; set; } 
        public string Author { get; set; }
        public string ISBN { get; set; }
        public int AvailableCopies { get; set; }
        public string Type {  get; set; }
        public Librarian AssignedLibrarian { get; set; } // reference to tje librarian responsible for the book

        // method to calculate on the book type 
        public decimal GetCost()
        {
            // Return cost based on the book type
            if (Type == "Fiction")
            {
                return 2;
            }
            else if (Type == "Science")
            {
                return 3;
            }
            else if (Type == "History")
            {
                return 2;
            }
            else if (Type == "Technology")
            {
                return 4;
            }
            else
            {
                return 0; // Default cost for unknown types
            }
        }

        // method to display book information on the console
        public void DisplayBookInfo()
        {
            Console.WriteLine($"Book:{Title} , Author: {Author} , ISBN: {ISBN}, Type: {Type} , AvailableCopies: {AvailableCopies}");
        }

        



    }
}
