namespace LibraryManagement
{
    public class Member
    {
        public int memberId { get; set; }
        public string name { get; set; }
        public string issuedBook { get; set; }
        public void DisplayMemberDetails()
        {
            Console.WriteLine("Member details:");
            Console.WriteLine($"Member ID: {memberId}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Issued Book: {issuedBook}");
        }
    }
}
