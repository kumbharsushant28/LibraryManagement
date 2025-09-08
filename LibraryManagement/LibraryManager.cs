using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using static System.Reflection.Metadata.BlobBuilder;

namespace LibraryManagement
{
    internal class LibraryManager
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            Console.WriteLine("Welcome to the Library Management System");
            int choice = 0;

            do
            {
                Console.WriteLine("\n1.Add Book\n2.Remove Book\n3.Add Member\n4.Remove Member\n5.Issue Book\n6.Return Book\n7.List All Books\n8.List All Members\n9.Exit Application");
                Console.WriteLine("enter your choice:");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        // Code to add book
                        Book addedbook = library.AddBook();
                        addedbook.DisplayBookDetails();
                        break;
                    case 2:
                        // Code to remove book
                        Book removedbook = library.RemoveBook();
                        removedbook.DisplayBookDetails();
                        break;
                    case 3:
                        // Code to add member
                        Member addedmember = library.AddMember();
                        addedmember.DisplayMemberDetails();
                        break;
                    case 4:
                        // Code to remove member
                        Member removedmember = library.RemoveMember();
                        removedmember.DisplayMemberDetails();
                        break;
                    case 5:
                        // Code to issue book
                        library.IssueBook();
                        break;
                    case 6:
                        // Code to return book
                        library.ReturnBook();
                        break;
                    case 7:
                        // Code to list all books
                        library.ListAllBooks();
                        break;
                    case 8:
                        // Code to list all members
                        library.ListAllMembers();
                        break;
                    case 9:
                        Console.WriteLine("Exiting application.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != 9);
        }
    }
}
