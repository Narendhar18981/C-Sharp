namespace Customer_Support_Management_System.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string IssueDescription { get; set; }
        public string Status { get; set; } // e.g., "Open", "In Progress", "Closed"
        public DateTime CreatedAt { get; set; }
        public string CustomerId { get; set; }  // Foreign key to ApplicationUser
        public AppUser Customer { get; set; }  // Navigation property
    }
}
