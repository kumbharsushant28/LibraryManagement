namespace LibraryManagement
{
    public class Book
    {
        public int bookId { get; set; }
        public string title { get; set; }
        public string author { get; set; }
        public bool isIssued { get; set; }

        public void DisplayBookDetails()
        {
            Console.WriteLine("Book details:");
            Console.WriteLine($"Book ID: {bookId}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Is Issued: {isIssued}");
        }
    }
}
