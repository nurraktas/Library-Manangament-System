using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__project_1_Library_manangament_system_
{
    public class Library
    {
        public List<Book> Books;
        public List<Member> Members;
        public List<Librarian> Librarians;

        public Library()
        {
            Books = new List<Book>();
            Members = new List<Member>();
            Librarians = new List<Librarian>();

        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }
        public void RegisterMember(Member member)
        {
            Members.Add(member);
        }
        public void RegisterLibrarian(Librarian librarian)
        {
            Librarians.Add(librarian);
        }

        // Method to assign a librarian to a specific book based on their specialty
        public void AssignLibrarianToBook(Book book)
        { 
            // Find a librarian whose specialty matches the book type
            var librarian = Librarians.FirstOrDefault(l => l.Speciality.Equals(book.Type, StringComparison.OrdinalIgnoreCase));

            if (librarian != null)
            {
                book.AssignedLibrarian = librarian;
                Console.WriteLine($"Librarian {librarian.Name}, assigned to {book.Title} ");
            } else
            {
                book.AssignedLibrarian = null;
                Console.WriteLine($"No librarian assigned for {book.Title}.");

            }
        }
        // Method to display information about all books in the library
        public void DisplayAllBooks()
        {
            foreach (var book in Books) 
            {
                book.DisplayBookInfo();
            }
        }
        // Method to display information about all members in the library
        public void DisplayAllMembers()
        {
            foreach(var member in Members)
            {
                member.DisplayInfo();
            }
        }

        // Method to display information about all librarians in the library
        public void DisplayAllLibrarians()
        {
            foreach(var librarian in Librarians)
            {
                librarian.DisplayInfo();
            }
        }
    
    }
}
