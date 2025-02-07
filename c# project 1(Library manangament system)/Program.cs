using c__project_1_Library_manangament_system_;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();   // Create a new library instance
            bool exit = false;
            // Main loop for the menu until user selects to exit
            while (!exit)
            {
                Console.WriteLine("\nLibrary Management System:");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Register Member");
                Console.WriteLine("3. Register Librarian");
                Console.WriteLine("4. Borrow Book");
                Console.WriteLine("5. Return Book");
                Console.WriteLine("6. View All Books");
                Console.WriteLine("7. View All Members");
                Console.WriteLine("8. View All Librarians");
                Console.WriteLine("9. Exit");
                Console.Write("Select an option: ");
                // Get user input for menu option
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }
                // Switch case to handle each menu option
                switch (choice)
                {
                    case 1:
                        AddBook(library); // Add a new book
                        break;

                    case 2:
                        RegisterMember(library); // Register a new member
                        break;

                    case 3:
                        RegisterLibrarian(library);  // Register a new librarian
                        break;


                    case 4:
                        BorrowBook(library); // Borrow a book
                        break;

                    case 5:
                        ReturnBook(library); // Return a borrowed book
                        break;

                    case 6:
                        library.DisplayAllBooks(); // Display all books in the library
                        break;

                    case 7:
                        library.DisplayAllMembers(); // Display all members of the library
                        break;

                    case 8:
                        library.DisplayAllLibrarians();  // Display all librarians in the library
                        break;

                    case 9:
                        exit = true; // Exit the program
                        break;

                    default:
                        Console.WriteLine("Invalid option."); // Handle invalid input
                        break;
                }
            }
        }

        // Function to add a new book to the library
        static void AddBook(Library library)
        {
            Console.Write("Enter Book Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Author: ");
            string author = Console.ReadLine();
            Console.Write("Enter ISBN: ");
            string isbn = Console.ReadLine();
            Console.Write("Enter Type (Fiction, Science, History, Technology): ");
            string type = Console.ReadLine();
            Console.Write("Enter Available Copies: ");
            int copies;
            if (!int.TryParse(Console.ReadLine(), out copies))
            {
                Console.WriteLine("Invalid number of copies.");
                return;
            }
            // Create a new book object and add it to the library
            Book book = new Book { Title = title, Author = author, ISBN = isbn, Type = type, AvailableCopies = copies };
            library.AddBook(book);
        }

        // Function to register a new member
        static void RegisterMember(Library library)
        {
            Console.Write("Enter Member Name: ");
            string memberName = Console.ReadLine();
            Console.Write("Enter Member ID: ");
            string memberID = Console.ReadLine();
            Console.Write("Enter Membership Type (Basic/Premium): ");
            string membershipType = Console.ReadLine();
            // Create a new member object and register it with the library
            Member member = new Member(memberID, memberName, membershipType);
            library.RegisterMember(member);
        }

        // Function to register a new librarian
        static void RegisterLibrarian(Library library)
        {
            Console.Write("Enter Librarian Name: ");
            string librarianName = Console.ReadLine();
            Console.Write("Enter Librarian ID: ");
            string librarianID = Console.ReadLine();
            Console.Write("Enter Salary: ");
            decimal salary;
            if (!decimal.TryParse(Console.ReadLine(), out salary))
            {
                Console.WriteLine("Invalid salary input.");
                return;
            }
            Console.Write("Enter Specialty (Fiction, Science, History, Technology): ");
            string specialty = Console.ReadLine();

            // Create a new librarian object and register it with the library
            Librarian librarian = new Librarian(librarianID, librarianName, salary, specialty);
            library.RegisterLibrarian(librarian);
        }

        // Function for a member to borrow a book
        static void BorrowBook(Library library)
        {
            Console.Write("Enter Member ID: ");
            string borrowMemberID = Console.ReadLine();
            Console.Write("Enter Book ISBN: ");
            string borrowISBN = Console.ReadLine();

            // Function for a member to borrow a book
            Member borrowMember = library.Members.Find(m => m.PersonID == borrowMemberID);
            Book borrowBook = library.Books.Find(b => b.ISBN == borrowISBN);
            // Check if both member and book exist before borrowing
            if (borrowMember != null && borrowBook != null)
            {
                library.AssignLibrarianToBook(borrowBook); // Assign a librarian to the book
                borrowMember.BorrowBook(borrowBook);  // The member borrows the book

            }
            else
            {
                Console.WriteLine("Invalid Member ID or ISBN."); // Handle invalid member or book
            }
        }

        // Function for a member to return a book
        static void ReturnBook(Library library)
        {
            Console.Write("Enter Member ID: ");
            string returnMemberID = Console.ReadLine();
            Console.Write("Enter Book ISBN: ");
            string returnISBN = Console.ReadLine();

            // Find the member in the library collections
            Member returnMember = library.Members.Find(m => m.PersonID == returnMemberID);
            if (returnMember != null)
            {
                returnMember.ReturnBook(returnISBN);  // The member returns the book
            }
            else
            {
                Console.WriteLine("Invalid Member ID."); // Handle invalid member
            }
        }
    }
}



