using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetCoreAPI.Models
{
    [Table("UserRole", Schema = "auth")]
    public class UserRole
    {
        public Guid UserId { get; set; }
        public Guid RoleId { get; set; }

        public User User { get; set; }
        public Role Role { get; set; }
    }
}