using System.ComponentModel.DataAnnotations;

namespace NetCoreAPI.DTOs
{
    public class UserRegisterDto
    {
        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }
    }
}