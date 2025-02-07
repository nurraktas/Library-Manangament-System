using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__project_1_Library_manangament_system_
{
    public class Member : PersonBase
    {
        public string MembershipType { get; set; }// Type of membership (e.g., Regular, Premium)
     
        public Dictionary<string, Book> BookBorrowed { get; set; } = new Dictionary<string, Book>();
        public decimal Balance { get; set; }


        public Member(string personID, string name , string membershipType)
            : base(personID, name)
        {
            MembershipType = membershipType;
        }

        public void BorrowBook(Book book)
        {
            if (book.AvailableCopies > 0 ) 
            {
                BookBorrowed[book.ISBN] = book;
                book.AvailableCopies --;
                Console.WriteLine($"Book borrowed: {book.Title} , Remand available copies : {book.AvailableCopies} ");
            }else
            {
                Console.WriteLine("No copies available");
            }

                    
        }

        public decimal ReturnBook(string isbn)
        {
            if (BookBorrowed.ContainsKey(isbn))
            {
                Book book = BookBorrowed[isbn];
                decimal fee = book.GetCost();
                Balance += fee;
                BookBorrowed.Remove(isbn);
                book.AvailableCopies ++;
                Console.WriteLine($"Book returned: {book.Title}, Fee: {fee:C}");
                return fee;
            }
            else
            {
                Console.WriteLine("no such book borrowed.");
                return 0;
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Member : {Name} , ID:{PersonID}, Membership Type: {MembershipType}, Balance:{Balance:C} ");
        }


    }
}
