using System;
using System.ComponentModel.DataAnnotations;

namespace NetCoreAPI.Models
{
    public class StockCardType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}