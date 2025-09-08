namespace LibraryManagement
{
    public class Library
    {
        public List<Book> books { get; set; } = new List<Book>();

        public List<Member> members { get; set; } = new List<Member>();

        public Book AddBook()
        {
            Console.WriteLine("Adding book");
            Console.WriteLine("Enter Book ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Title:");
            string title = Console.ReadLine();
            Console.WriteLine("Enter Author:");
            string author = Console.ReadLine();

            Book newBook = new Book
            {
                bookId = id,
                title = title,
                author = author,
                isIssued = false
            };

            books.Add(newBook);
            Console.WriteLine("Book added successfully.");
            return newBook;
        }

        public Book RemoveBook()
        {
            Console.WriteLine("Enter the bookid to remove:");
            int id = int.Parse(Console.ReadLine());
            Book bookToRemove = books.FirstOrDefault(b => b.bookId == id);
            books.Remove(bookToRemove);
            Console.WriteLine("Book removed successfully.");
            return bookToRemove;
        }

        public Member AddMember()
        {
            Console.WriteLine("Adding member");
            Console.WriteLine("Enter Member ID:");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            string nm = Console.ReadLine();
            Member newMember = new Member
            {
                memberId = id,
                name = nm,
                issuedBook = "No book issued"
            };
            members.Add(newMember);
            return newMember;
        }

        public Member RemoveMember()
        {
            Console.WriteLine("Enter MemberId to remove member:");
            int id = int.Parse(Console.ReadLine());
            Member MemberToRemove = members.FirstOrDefault(m => m.memberId == id);
            members.Remove(MemberToRemove);
            Console.WriteLine("Member removed successfully.");
            return MemberToRemove;
        }

        public void IssueBook()
        {
            Console.WriteLine("Enter book name to issue");
            string bookname = Console.ReadLine();
            Book bookToIoIssue = books.FirstOrDefault(b => b.title == bookname || b.isIssued.Equals("false"));
            if (bookToIoIssue != null)
            {
                Console.WriteLine("book is available to issue");
                Console.WriteLine("Enter member name to issue book");
                string membername = Console.ReadLine();
                Member memberToIssue = members.FirstOrDefault(m => m.name == membername || m.issuedBook.Equals(null));
               if( memberToIssue != null)
                {
                    Console.WriteLine("member is available to issue book");

                    //issue book to member
                    memberToIssue.issuedBook = bookToIoIssue.title;

                    //mark book as issued
                    bookToIoIssue.isIssued = true;
                    Console.WriteLine("book issued successfully");
                }
                else
                {
                    Console.WriteLine("member is not available to issue book");
                }

            }
            else
            {
                Console.WriteLine("book is not available to issue");
            }
        }

        public void ReturnBook()
        {
            Console.WriteLine("Enter member id to return a book");
            int memberid = int.Parse(Console.ReadLine());
            Member memberToReturn = members.FirstOrDefault(m => m.memberId == memberid || m.issuedBook != null);
            if (memberToReturn != null)
            {
                Console.WriteLine($"Member has issued book {memberToReturn.issuedBook}");
                Book bookToReturn = books.FirstOrDefault(b=>b.title == memberToReturn.issuedBook);
                if (bookToReturn != null)
                {
                    //return book to library from member
                    memberToReturn.issuedBook = null;

                    //mark book as not issued
                    bookToReturn.isIssued = false;
                    Console.WriteLine("Book returned successfully");
                }
            }
        }

        public void ListAllBooks()
        {
            foreach (var book in books)
            {
                book.DisplayBookDetails();
            }
        }

        public void ListAllMembers()
        {
            foreach (var member in members)
            {
                member.DisplayMemberDetails();
            }
        }
    }
}
