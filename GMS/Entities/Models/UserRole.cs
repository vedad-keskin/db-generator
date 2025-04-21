using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eCommerce.Services.Database
{
    public class UserRole
    {
        [Key]
        public int Id { get; set; }
        
        // User
        public int UserId { get; set; }
        
        [ForeignKey("UserId")]
        public User User { get; set; } = null!;
        
        // Role
        public int RoleId { get; set; }
        
        [ForeignKey("RoleId")]
        public Role Role { get; set; } = null!;
        
        public DateTime DateAssigned { get; set; } = DateTime.UtcNow;
    }
} 