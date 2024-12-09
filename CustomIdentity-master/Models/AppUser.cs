using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Customer_Support_Management_System.Models;

public class AppUser : IdentityUser
{
    [StringLength(100)]
    [MaxLength(100)]
    [Required]
    public string? Name { get; set; }
    public string? Address { get; set; }
}
